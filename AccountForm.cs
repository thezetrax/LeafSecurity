using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SecuGen.FDxSDKPro.Windows;

namespace LeafSecurity
{
    public partial class AccountForm : Form
    {
        // Instance Properties
        private bool errorEncountered;
        private bool fingerprint_device_connected;
        // Instances Used for fingerprint
        private Int32 iError;
        private Int32 img_w;
        private Int32 img_h;
        private Int32 img_dpi;
        private Int32 pInfo;
        private SGFingerPrintManager m_FPM;
        private SGFPMDeviceName device_name;
        private Int32 port_addr;
        private string savedFingerprintFilePath;
        private AccountInformation m_accountInformation;

        public bool fingerprintTaken { get; private set; }

        public AccountForm()
        {
            InitializeComponent();
            fingerprint_device_connected = false;
            fingerprintTaken = false;
            // account not selected
            m_accountInformation = null;
        }

        public AccountForm(AccountInformation account)
        {
            InitializeComponent();
            fingerprint_device_connected = false;
            fingerprintTaken = false;
            // account is selected
            m_accountInformation = account;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            // Adding AccountTypes to Selection ComboBox
            using (LeafSecurityEntities db = new LeafSecurityEntities())
            {
                // Populating ComboList with AccountType(s).
                foreach (AccountType aType in db.AccountTypes)
                {
                    accountTypeCombo.Items.Add(aType.TypeName);
                }

                if (m_accountInformation != null)
                {
                    // Gathering User Information
                    UserInformation userInfo = (from acc in db.UserInformations
                                                where acc.AccountID == m_accountInformation.AccountID
                                                select acc).First();
                    int accType = userInfo.AccountInformation.AccountType.TypeID;

                    // Setting up AccountForm()
                    // User Information
                    firstNameTxt.Text = userInfo.FirstName.ToString();
                    lastNameTxt.Text = userInfo.LastName;
                    if (userInfo.Email != null)
                        emailTxt.Text = userInfo.Email;
                    if (userInfo.PhoneNumber != null)
                        phoneNumberTxt.Text = userInfo.PhoneNumber;
                    if (userInfo.Address != null)
                        addressTxt.Text = userInfo.Address;
                    // If Admin Account Selected
                    if (accType.Equals(1))
                    {
                        accountTypeCombo.SelectedItem = accountTypeCombo.Items[0];
                        passwordTxt.Text = m_accountInformation.AccountPinCode;
                        confirmPasswordTxt.Text = m_accountInformation.AccountPinCode;
                        stringHashTxt.Text = "Admin Account Doesn't Contain This Item.";
                    }
                    // If User Account Seleted
                    else
                    {
                        accountTypeCombo.SelectedIndex = 1;
                        passwordTxt.Text = m_accountInformation.AccountPinCode;
                    }
                    // AccountInformation
                    usernameTxt.Text = userInfo.AccountInformation.AccountNumber;
                    // BiometricInformation
                    if (accType.Equals(2))
                    {
                        // Gathering Fingerprint Information
                        FingerprintTemplate fingerTemplate = (from acc in db.FingerprintTemplates
                                                              where acc.AccountID == m_accountInformation.AccountID
                                                              select acc).First();
                        // Only works for User Accounts
                        stringHashTxt.Text = Path.GetFileName(fingerTemplate.MinutiaeTemplatePath.TemplatePath);
                        generateHashBtn.Enabled = false;
                    }

                }
            }

            // Enabling Sensor(s)
            m_FPM = new SGFingerPrintManager();
            device_name = SGFPMDeviceName.DEV_FDU03;
            // ...Initializing Port Address
            port_addr = (Int32)SGFPMPortAddr.USB_AUTO_DETECT;
            // ...Initializing Device (HSDUO03P)
            m_FPM.Init(device_name);
            iError = m_FPM.OpenDevice(port_addr);
            fingerprint_device_connected = true;
            if (iError != (Int32)SGFPMError.ERROR_NONE)
            {
                //DialogResult res = MessageBox.Show(this, "Are you sure you have a fingerprint sensor connected?",
                //    "Fingerprint Sensor not Connected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Console.WriteLine("OpenDevice() Error : " + iError);
                fingerprint_device_connected = false;
            }

            if (fingerprint_device_connected)
            {
                // Hiding Some Controls,
                // These controls are only used when fingerprint is not available.
                imageFilePath.Hide();
                templatePathLbl.Hide();
                openTempFileBtn.Hide();
                groupBox3.Height = 450;

                // ...Enabling Auto-On Feature
                m_FPM.EnableAutoOnEvent(true, (int)this.Handle);
                AutoReadFingerprint_chk.Checked = true;

                // Getting Device Info
                SGFPMDeviceInfoParam pInfo = new SGFPMDeviceInfoParam();
                pInfo = new SGFPMDeviceInfoParam();
                iError = m_FPM.GetDeviceInfo(pInfo);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                {
                    img_w = pInfo.ImageWidth;
                    img_h = pInfo.ImageHeight;
                    img_dpi = pInfo.ImageDPI;
                }
            } else
            {
                // Hiding Some Controls,
                // These controls are only used when fingerprint is available.
                FingerprintPreviewBox.Hide();
                AutoReadFingerprint_chk.Hide();
                ReadFingerprintBtn.Hide();
                fingerprint_preview_lbl.Hide();
            }

            // disabling buttons that are used afer selecting account type
            AutoReadFingerprint_chk.Checked = false;
            AutoReadFingerprint_chk.Enabled = false;
            FingerprintPreviewBox.Hide();
            copyHashBtn.Enabled = false;
            ReadFingerprintBtn.Enabled = false;
            openTempFileBtn.Enabled = false;
            imageFilePath.Enabled = false;
        }

        private void openTempFileBtn_Click(object sender, EventArgs e)
        {
            openTemplateDialog.ShowDialog();
        }

        private void openTemplateDialog_FileOk(object sender, CancelEventArgs e)
        {
            imageFilePath.Text = openTemplateDialog.FileName;
            generateHashString();
            fingerprintTaken = true;
        }

        private void generateHashString()
        {
            stringHashTxt.Text = RandomGen.Generate.RandomString(128, true);
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            errorEncountered = false;
            using (LeafSecurityEntities db = new LeafSecurityEntities())
            {
                // Checking Personal Information Data. (First Name)
                if(firstNameTxt.Text.Length.Equals(0))
                {
                    errorEncountered = true;
                    firstNameLbl.ForeColor = Color.Red;
                    errorLbl.Show();
                }

                // Checking Personal Information Data. (Last Name)
                if (lastNameTxt.Text.Length.Equals(0))
                {
                    errorEncountered = true;
                    lastNameLbl.ForeColor = Color.Red;
                    errorLbl.Show();
                }

                // Checking Personal Information Data. (Email)
                if (emailTxt.Text.Length.Equals(0))
                {
                    inputTab.SelectTab(0);
                    emailLbl.ForeColor = Color.Blue;
                    DialogResult result = MessageBox.Show("Are you sure you want to leave some fields blank", "Are you sure?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        errorEncountered = true;
                }

                // Checking Personal Information Data. (Phone Number)
                if (phoneNumberTxt.Text.Length.Equals(0))
                {
                    inputTab.SelectTab(0);
                    phoneNumberLbl.ForeColor = Color.Blue;
                    DialogResult result = MessageBox.Show("Are you sure you want to leave some fields blank", "Are you sure?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        errorEncountered = true;
                }

                // Checking Personal Information Data.
                if (addressTxt.Text.Length.Equals(0))
                {
                    inputTab.SelectTab(0);
                    addressLbl.ForeColor = Color.Blue;
                    DialogResult result = MessageBox.Show("Are you sure you want to leave some fields blank", "Are you sure?", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        errorEncountered = true;
                }

                // Checking Account Data
                IEnumerable<AccountInformation> anotherAcc =    from acc in db.AccountInformations
                                                                where acc.AccountNumber == usernameTxt.Text
                                                                select acc;
                if(!anotherAcc.Count().Equals(0))
                {
                    errorEncountered = true;
                    usernameLbl.ForeColor = Color.Red;
                    usernameErrorTooltip.SetToolTip(this.usernameLbl, "User name exists");
                    usernameErrorTooltip.SetToolTip(this.usernameTxt, "User name exists");
                    errorLbl.Show();
                }

                if (usernameTxt.Text.Length.Equals(0))
                {
                    errorEncountered = true;
                    usernameLbl.ForeColor = Color.Red;
                    usernameErrorTooltip.SetToolTip(this.usernameLbl, "User name not entered.");
                    usernameErrorTooltip.SetToolTip(this.usernameTxt, "User name not entered.");
                    errorLbl.Show();
                }

                if (passwordTxt.Text.Length.Equals(0))
                {
                    errorEncountered = true;
                    passwordLbl.ForeColor = Color.Red;
                    confirmPasswordLbl.ForeColor = Color.Red;
                    passwordErrorTooltip.SetToolTip(this.passwordLbl, "Password not entered.");
                    passwordErrorTooltip.SetToolTip(this.confirmPasswordLbl, "Password not entered.");
                    passwordErrorTooltip.SetToolTip(this.passwordTxt, "Password not entered.");
                    passwordErrorTooltip.SetToolTip(this.confirmPasswordTxt, "Password not entered.");
                    errorLbl.Show();
                }

                if (!passwordTxt.Text.Equals(confirmPasswordTxt.Text) && accountTypeCombo.SelectedIndex.Equals(0))
                {
                    errorEncountered = true;
                    passwordLbl.ForeColor = Color.Red;
                    confirmPasswordLbl.ForeColor = Color.Red;
                    passwordErrorTooltip.SetToolTip(this.passwordLbl, "Password does not match.");
                    passwordErrorTooltip.SetToolTip(this.confirmPasswordLbl, "Password does not match.");
                    passwordErrorTooltip.SetToolTip(this.passwordTxt, "Password does not match.");
                    passwordErrorTooltip.SetToolTip(this.confirmPasswordTxt, "Password does not match.");
                    errorLbl.Show();
                }

                if (accountTypeCombo.SelectedIndex == -1)
                {
                    errorEncountered = true;
                    accountTypeLbl.ForeColor = Color.Red;
                    accountTypeErrorTooltip.SetToolTip(this.accountTypeLbl, "Account type not selected.");
                    accountTypeErrorTooltip.SetToolTip(this.accountTypeCombo, "Account type not selected.");
                }
                
                // Checking Template Information
                // If account type does require fingerprint template
                if(!accountTypeCombo.SelectedIndex.Equals(0))
                {
                    // If template file not provided
                    // and If template is nessesary, meaning fingerprint sensor is not connected
                    if(imageFilePath.Text.Length.Equals(0) && !fingerprint_device_connected)
                    {
                        errorEncountered = true;
                        templatePathLbl.ForeColor = Color.Red;
                        templatePathErrorTooltip.SetToolTip(this.templatePathLbl, "Template not provided.");
                        errorLbl.Show();
                    }

                    if(!File.Exists(imageFilePath.Text) && !fingerprint_device_connected)
                    {
                        errorEncountered = true;
                        templatePathLbl.ForeColor = Color.Red;
                        templatePathErrorTooltip.SetToolTip(this.templatePathLbl, "Template file doest not exist.");
                        errorLbl.Show();
                    }

                    // if Fingerprint Sensor is connected but
                    // fingerprint not read yet.
                    if(!this.fingerprintTaken)
                    {
                        errorEncountered = true;
                        fingerprint_preview_lbl.ForeColor = Color.Red;
                        templatePathErrorTooltip.SetToolTip(this.fingerprint_preview_lbl, "Fingerprint Not Provided.");
                        errorLbl.Show();
                    }
                }

                // Entering Verified Data
                if(!errorEncountered)
                {
                    if(accountTypeCombo.SelectedIndex.Equals(0))
                    {
                        // Account Information
                        AccountInformation accountInfo = new AccountInformation();
                        accountInfo.AccountNumber = usernameTxt.Text;
                        accountInfo.AccountPinCode = passwordTxt.Text;
                        accountInfo.TypeID = 1; // Since Account Type 'Admin' is identified as 1
                        accountInfo.AccountCreationDate = DateTime.Now;

                        db.AccountInformations.Add(accountInfo);
                        db.SaveChanges();

                        Console.WriteLine("Account ID: {0}", accountInfo.AccountID);

                        // User Information
                        UserInformation userInformation = new UserInformation();
                        //userInformation.AccountID = (from accTemp in db.AccountInformations
                        //                             where accTemp.AccountNumber == accountInfo.AccountNumber
                        //                             select accTemp).First().AccountID;
                        userInformation.AccountID = accountInfo.AccountID;
                        userInformation.FirstName = firstNameTxt.Text;
                        userInformation.LastName = lastNameTxt.Text;
                        userInformation.PhoneNumber = phoneNumberTxt.Text;
                        userInformation.Email = emailTxt.Text;
                        userInformation.Address = addressTxt.Text;

                        db.UserInformations.Add(userInformation);
                        db.SaveChanges();

                        MessageBox.Show(String.Format("User {0} added to database.", userInformation.FirstName + " " + userInformation.LastName), "User successfully added to database", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Console.WriteLine("User ID: {0}", userInformation.UserID);
                        Console.WriteLine("Account added to database.");
                    }
                    // If User Account Type is created.
                    else if (accountTypeCombo.SelectedIndex.Equals(1))
                    {
                        // Account Information
                        AccountInformation accountInfo = new AccountInformation();
                        accountInfo.AccountNumber = usernameTxt.Text;
                        accountInfo.AccountPinCode = passwordTxt.Text;
                        accountInfo.TypeID = 2; // Since Account Type 'User' is identified as 2
                        accountInfo.AccountCreationDate = DateTime.Now;

                        db.AccountInformations.Add(accountInfo);
                        db.SaveChanges();

                        Console.WriteLine("Account ID: {0}", accountInfo.AccountID);

                        // User Information
                        UserInformation userInformation = new UserInformation();
                        //userInformation.AccountID = (from accTemp in db.AccountInformations
                        //                             where accTemp.AccountNumber == accountInfo.AccountNumber
                        //                             select accTemp).First().AccountID;
                        userInformation.AccountID = accountInfo.AccountID;
                        userInformation.FirstName = firstNameTxt.Text;
                        userInformation.LastName = lastNameTxt.Text;
                        userInformation.PhoneNumber = phoneNumberTxt.Text;
                        userInformation.Email = emailTxt.Text;
                        userInformation.Address = addressTxt.Text;

                        db.UserInformations.Add(userInformation);
                        db.SaveChanges();

                        // Minutiae TemplatePath Information
                        DirectoryOps.DefaultApplicationDirectory appDatabaseDir =
                            new DirectoryOps.DefaultApplicationDirectory(Program.defaultApplicationDatabaseDirName);
                        DirectoryOps.DefaultApplicationDirectory matlabGeneratedDir =
                            new DirectoryOps.DefaultApplicationDirectory(Program.defaultMatlabGeneratedDirName);

                        /* Declaring variables used to store:
                         *      tempFingerprintFileName - Temporary Fingerprint File from fingerprint sensor.
                         *      generatedTemplateFileName - Matlab Generated Minutiea Template File.
                         * */

                        string tempFingerprintFileName;
                        string generatedTemplateFileName;

                        // Generating Template file using matlab
                        // If fingerprint sensor is connected, generateTemplate() using sensor image
                        // else use fingerprint image from image file
                        if (fingerprint_device_connected)
                        {
                            tempFingerprintFileName = saveFingerprintImage();
                            generatedTemplateFileName = generateTemplate(tempFingerprintFileName);
                        } else
                        {
                            generatedTemplateFileName = generateTemplate();
                        }


                        try
                        {
                            if (FileOps.FileOperation.Save(
                                    Path.Combine(matlabGeneratedDir.Path, generatedTemplateFileName), 
                                    appDatabaseDir.Path, stringHashTxt.Text))
                                Console.WriteLine("File saved as: {0}", Path.Combine(appDatabaseDir.Path, stringHashTxt.Text));
                        } catch (Exception exc)
                        {
                            MessageBox.Show(
                                    exc.Message, "Exception Occured!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                                );
                        }

                        MinutiaeTemplatePath minutiaeTemplatePath = new MinutiaeTemplatePath();
                        minutiaeTemplatePath.TemplatePath = Path.Combine(appDatabaseDir.Path, stringHashTxt.Text);
                        db.MinutiaeTemplatePaths.Add(minutiaeTemplatePath);
                        db.SaveChanges();

                        // Template Information
                        FingerprintTemplate fingerprintTemplate = new FingerprintTemplate();
                        fingerprintTemplate.AccountID = accountInfo.AccountID;
                        fingerprintTemplate.MinutiaeTemplateID = minutiaeTemplatePath.ID;
                        db.FingerprintTemplates.Add(fingerprintTemplate);
                        db.SaveChanges();


                        MessageBox.Show(String.Format("User {0} added to database.", userInformation.FirstName + " " + userInformation.LastName), "User successfully added to database",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Console.WriteLine("User ID: {0}", userInformation.UserID);
                        Console.WriteLine("Account added to database.");
                    }
                }
            }
        }

        // Saves Fingerprint temporarily in 
        // Application temp folder.
        private string saveFingerprintImage()
        {
            DirectoryOps.DefaultApplicationDirectory tempDir =
                            new DirectoryOps.DefaultApplicationDirectory(Program.defaultApplicationTempDir);
            // Generating temporary file name for the fingerprint image.
            string tempFileName = RandomGen.Generate.RandomString(4, true);
            tempFileName += ".tif";
            // Creating an Image Object to save as file
            Bitmap bmp = new Bitmap(260, 300);
            FingerprintPreviewBox.DrawToBitmap(bmp, FingerprintPreviewBox.ClientRectangle);
            ImageConverter imgConverter = new ImageConverter();
            // Converting the 32bit Image to 8bit (Indexed) Greyscale Image
            Bitmap bmpGrey = new Bitmap(260, 300, PixelFormat.Format8bppIndexed);
            bmpGrey = bmp.Clone(new Rectangle(0, 0, 260, 300), 
                PixelFormat.Format8bppIndexed);
            // Saving the Image object as Image File.
            bmpGrey.Save(Path.Combine(tempDir.Path, tempFileName), ImageFormat.Bmp);
            return tempFileName;
        }

        private void usernameErrorTooltip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void usernameTxt_Click(object sender, EventArgs e)
        {
            usernameLbl.ForeColor = Color.Black;
            usernameErrorTooltip.RemoveAll();
            errorLbl.Hide();
        }

        private void passwordTxt_Click(object sender, EventArgs e)
        {
            passwordLbl.ForeColor = Color.Black;
            confirmPasswordLbl.ForeColor = Color.Black;
            passwordErrorTooltip.RemoveAll();
            errorLbl.Hide();
        }

        private void confirmPasswordTxt_Click(object sender, EventArgs e)
        {
            passwordLbl.ForeColor = Color.Black;
            confirmPasswordLbl.ForeColor = Color.Black;
            passwordErrorTooltip.RemoveAll();
            errorLbl.Hide();
        }

        private void accountTypeCombo_Click(object sender, EventArgs e)
        {
            accountTypeLbl.ForeColor = Color.Black;
            accountTypeErrorTooltip.RemoveAll();
            errorLbl.Hide();
        }

        private void copyHashBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(stringHashTxt.Text);
        }

        private void templateFilePath_Click(object sender, EventArgs e)
        {
            templatePathLbl.ForeColor = Color.Black;
            templatePathErrorTooltip.RemoveAll();
            errorLbl.Hide();
        }

        private void firstNameTxt_Click(object sender, EventArgs e)
        {
            firstNameLbl.ForeColor = Color.Black;
            fieldTooltip.RemoveAll();
            errorLbl.Hide();
        }

        private void lastNameTxt_Click(object sender, EventArgs e)
        {
            lastNameLbl.ForeColor = Color.Black;
            fieldTooltip.RemoveAll();
            errorLbl.Hide();
        }

        private void emailTxt_Click(object sender, EventArgs e)
        {
            emailLbl.ForeColor = Color.Black;
            fieldTooltip.RemoveAll();
            errorLbl.Hide();
        }

        private void phoneNumberTxt_Click(object sender, EventArgs e)
        {
            phoneNumberLbl.ForeColor = Color.Black;
            fieldTooltip.RemoveAll();
            errorLbl.Hide();
        }

        private void addressTxt_Click(object sender, EventArgs e)
        {
            addressLbl.ForeColor = Color.Black;
            fieldTooltip.RemoveAll();
            errorLbl.Hide();
        }

        private void genereateHashBtn_Click(object sender, EventArgs e)
        {
            generateHashString();
        }

        private string generateTemplate()
        {
            DirectoryOps.DefaultApplicationDirectory matlabFunctionDir =
                new DirectoryOps.DefaultApplicationDirectory(Program.defaultMatlabFunctionDirName);

            // creating function object
            MatLabOps.MatLabOps.FunctionProperties func = new MatLabOps.MatLabOps.FunctionProperties();
            func.functionPath = matlabFunctionDir.Path;
            func.functionName = @"auto_generate_minutiae";
            func.nArgOut = 1;

            // Gerated file name
            string tempName = RandomGen.Generate.RandomString(6, true);

            MatLabOps.MatLabOps.generateTemplate(func, Path.GetDirectoryName(imageFilePath.Text), 
                Path.GetFileName(imageFilePath.Text), tempName);

            return tempName;
        }

        private string generateTemplate(string FilePath)
        {
            DirectoryOps.DefaultApplicationDirectory matlabFunctionDir =
                new DirectoryOps.DefaultApplicationDirectory(Program.defaultMatlabFunctionDirName);
            DirectoryOps.DefaultApplicationDirectory tempDir =
                new DirectoryOps.DefaultApplicationDirectory(Program.defaultApplicationTempDir);

            // creating function object
            MatLabOps.MatLabOps.FunctionProperties func = new MatLabOps.MatLabOps.FunctionProperties();
            func.functionPath = matlabFunctionDir.Path;
            func.functionName = @"auto_generate_minutiae";
            func.nArgOut = 1;

            // Generated file name
            string tempName = RandomGen.Generate.RandomString(6, true);

            MatLabOps.MatLabOps.generateTemplate(func, tempDir.Path,
                FilePath, tempName);

            return tempName;
        }

        private void accountTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // (Admin) Account Type is selected.
            if(accountTypeCombo.SelectedIndex.Equals(0))
            {
                copyHashBtn.Enabled = false;
                generateHashBtn.Enabled = false;
                imageFilePath.Enabled = false;
                openTempFileBtn.Enabled = false;
                
                // Set preferences for Admin Type Accounts.
                usernameLbl.Text = "Username*";
                passwordLbl.Text = "Password*";
                passwordTxt.PasswordChar = '*';
                confirmPasswordLbl.Visible = true;
                confirmPasswordTxt.Visible = true;
                copyBtn.Visible = false;
                genNumberBtn.Visible = false;
                genPinBtn.Visible = false;
                // Hiding Fingerprint Fields
                FingerprintPreviewBox.Hide();
                AutoReadFingerprint_chk.Hide();
                ReadFingerprintBtn.Hide();
                fingerprint_preview_lbl.Hide();

                // Clearing textboxes and fingerprint fields
                usernameTxt.Text = "";
                passwordTxt.Text = "";
                confirmPasswordTxt.Text = "";
                stringHashTxt.Text = "";
                fingerprintTaken = false;
            }
            // (User) Account Type is selected.
            else
            {
                copyHashBtn.Enabled = true;
                generateHashBtn.Enabled = true;

                // Set preferences for User Type Accounts.
                usernameLbl.Text = "Number";
                passwordLbl.Text = "Pin Code";
                passwordTxt.PasswordChar = '\0';
                confirmPasswordLbl.Visible = false;
                confirmPasswordTxt.Visible = false;
                copyBtn.Visible = true;
                genNumberBtn.Visible = true;
                genPinBtn.Visible = true;

                if(fingerprint_device_connected)
                {
                    FingerprintPreviewBox.Show();
                    AutoReadFingerprint_chk.Show();
                    ReadFingerprintBtn.Show();
                    FingerprintPreviewBox.Enabled = true;
                    AutoReadFingerprint_chk.Enabled = true;
                    ReadFingerprintBtn.Enabled = true;
                    AutoReadFingerprint_chk.Checked = true;
                } else
                {
                    imageFilePath.Show();
                    openTempFileBtn.Show();
                    imageFilePath.Enabled = true;
                    openTempFileBtn.Enabled = true;
                }

                // Generating Account Number & Pincode
                generateAccountNumber();
                generatePinCode();
            }
        }

        private void generatePinCode()
        {
            int newPinCode = RandomGen.Generate.RandomNumber(1000, 9999);
            passwordTxt.Text = newPinCode.ToString();
        }

        private void generateAccountNumber()
        {
            int newAccountNumber = RandomGen.Generate.RandomNumber(10000000, 99999999);

            using (LeafSecurityEntities db = new LeafSecurityEntities())
            {
                IEnumerable<AccountInformation> acc = from account in db.AccountInformations
                                                      where account.AccountNumber
                                                                   .ToString()
                                                                   .Equals(newAccountNumber.ToString())
                                                      select account;
                
                if(!acc.Count().Equals(0))
                {
                    newAccountNumber = RandomGen.Generate.RandomNumber(1000, 9999);
                }
            }

            usernameTxt.Text = newAccountNumber.ToString();
        }

        private void genPinBtn_Click(object sender, EventArgs e)
        {
            generatePinCode();
        }

        private void genNumberBtn_Click(object sender, EventArgs e)
        {
            generateAccountNumber();
        }

        // Fingerprint Methods
        private void captureFingerprint()
        {
            // Getting fp image as byte[]
            byte[] fp_image_byte = new Byte[img_w * img_h];
            iError = m_FPM.GetImage(fp_image_byte);

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                DrawFingerprint(fp_image_byte, FingerprintPreviewBox);
            }

            generateHashString();
        }

        private void DrawFingerprint(Byte[] imgData, PictureBox picBox)
        {
            int colorval;
            Bitmap bmp = new Bitmap(img_w, img_h);
            picBox.Image = (Image)bmp;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    colorval = (int)imgData[(j * img_w) + i];
                    bmp.SetPixel(i, j, Color.FromArgb(colorval, colorval, colorval));
                }
            }
            picBox.Refresh();
            fingerprintTaken = true;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == (int)SGFPMMessages.DEV_AUTOONEVENT)
            {
                if (m.WParam.ToInt32() == (Int32)SGFPMAutoOnEvent.FINGER_ON)
                {
                    captureFingerprint();
                }
            }
            base.WndProc(ref m);
        }

        private void AutoReadFingerprint_chk_CheckedChanged(object sender, EventArgs e)
        {
            if(AutoReadFingerprint_chk.Checked == true)
            {
                m_FPM.EnableAutoOnEvent(true, (int) this.Handle);
                ReadFingerprintBtn.Enabled = false;
            } else
            {
                m_FPM.EnableAutoOnEvent(false, (int)this.Handle);
                ReadFingerprintBtn.Enabled = true;
            }
        }

        private void ReadFingerprintBtn_Click(object sender, EventArgs e)
        {
            captureFingerprint();
        }

        private void imageFilePath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
