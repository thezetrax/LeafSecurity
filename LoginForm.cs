using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecuGen.FDxSDKPro.Windows;

namespace LeafSecurity
{
    public partial class LoginForm : Form
    {
        DashBoardForm dash;
        public LoginForm()
        {
            InitializeComponent();
            this.dash = new DashBoardForm();
        }

        public LoginForm(DashBoardForm dash)
        {
            InitializeComponent();
            this.dash = dash;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            using (LeafSecurityEntities db = new LeafSecurityEntities())
            {
                IEnumerable<AccountInformation> adminAccount = (from account in db.AccountInformations
                                                   where account.AccountNumber == usernameTxt.Text &&
                                                         account.TypeID.Equals(1)
                                                   select account);
                
                if (adminAccount.Count().Equals(0))
                {
                    MessageBox.Show("Account doesn't exist. Try again.", "Account doesn't exist", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else if(!adminAccount.FirstOrDefault().AccountPinCode.Equals(passwordTxt.Text))
                {
                    MessageBox.Show("Password not correct. Try again.", "Account Password Wrong",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    dash.Show(this);
                    this.Hide();
                }
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text.Length != 0)
                LoginBtn.Enabled = true;
            else
                LoginBtn.Enabled = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Creating directory objects for application folder
            DirectoryOps.DefaultApplicationDirectory defaultDir = 
                new DirectoryOps.DefaultApplicationDirectory(Program.defaultApplicationDirName);
            DirectoryOps.DefaultApplicationDirectory defaultDatabaseDir = 
                new DirectoryOps.DefaultApplicationDirectory(Program.defaultApplicationDatabaseDirName);
            DirectoryOps.DefaultApplicationDirectory defaultMatlabDir = 
                new DirectoryOps.DefaultApplicationDirectory(Program.defaultMatlabFunctionDirName);
            DirectoryOps.DefaultApplicationDirectory defaultTempDir =
                new DirectoryOps.DefaultApplicationDirectory(Program.defaultApplicationTempDir);

            // Opening Operation Objects for each folder.
            DirectoryOps.DirectoryOperation dirOperations = 
                new DirectoryOps.DirectoryOperation(defaultDir);
            DirectoryOps.DirectoryOperation dbDirOperations = 
                new DirectoryOps.DirectoryOperation(defaultDatabaseDir);
            DirectoryOps.DirectoryOperation matlabDirOperations =
                new DirectoryOps.DirectoryOperation(defaultMatlabDir);
            DirectoryOps.DirectoryOperation tempDirOperations =
                new DirectoryOps.DirectoryOperation(defaultTempDir);
            
            // If application Folder and application database folder
            // do not exist create them.
            if(!dirOperations.Exists())
                dirOperations.Create();
            if(!dbDirOperations.Exists())
                dbDirOperations.Create();
            if (!matlabDirOperations.Exists())
                matlabDirOperations.Create();
            if (!tempDirOperations.Exists())
                tempDirOperations.Create();

            // Checking if Fingerprint Machine is Connected
            SGFingerPrintManager m_FPM = new SGFingerPrintManager();
            SGFPMDeviceName device_name = SGFPMDeviceName.DEV_FDU03;
            //...Initializing Port Address
            Int32 port_addr = (Int32) SGFPMPortAddr.USB_AUTO_DETECT;
            m_FPM.Init(device_name);
            Int32 iError = m_FPM.OpenDevice(port_addr);
            if(iError != (Int32) SGFPMError.ERROR_NONE)
            {
                DialogResult res = MessageBox.Show(this, "Are you sure you want to continue with out a fingerprint sensor?",
                    "Fingerprint Sensor not Connected", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                Console.WriteLine("OpenDevice() Error : " + iError);
                if (res == DialogResult.No) Application.Exit();
                dash.fp_device_connected(false);
            }
            dash.fp_device_connected(true);
        }
    }
}
