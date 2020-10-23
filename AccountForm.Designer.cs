namespace LeafSecurity
{
    partial class AccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.inputTab = new System.Windows.Forms.TabControl();
            this.personalInfoTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.phoneNumberTxt = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.accountInformationTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copyBtn = new System.Windows.Forms.Button();
            this.genNumberBtn = new System.Windows.Forms.Button();
            this.genPinBtn = new System.Windows.Forms.Button();
            this.accountTypeCombo = new System.Windows.Forms.ComboBox();
            this.accountTypeLbl = new System.Windows.Forms.Label();
            this.confirmPasswordLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.confirmPasswordTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.fingerprintTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fingerprint_preview_lbl = new System.Windows.Forms.Label();
            this.FingerprintPreviewBox = new System.Windows.Forms.PictureBox();
            this.ReadFingerprintBtn = new System.Windows.Forms.Button();
            this.AutoReadFingerprint_chk = new System.Windows.Forms.CheckBox();
            this.templatePathLbl = new System.Windows.Forms.Label();
            this.imageFilePath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.openTempFileBtn = new System.Windows.Forms.Button();
            this.stringHashTxt = new System.Windows.Forms.TextBox();
            this.copyHashBtn = new System.Windows.Forms.Button();
            this.generateHashBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.openTemplateDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorLbl = new System.Windows.Forms.Label();
            this.usernameErrorTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.passwordErrorTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.accountTypeErrorTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.templatePathErrorTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.fieldTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.inputTab.SuspendLayout();
            this.personalInfoTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.accountInformationTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.fingerprintTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FingerprintPreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTab
            // 
            this.inputTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTab.Controls.Add(this.personalInfoTab);
            this.inputTab.Controls.Add(this.accountInformationTab);
            this.inputTab.Controls.Add(this.fingerprintTab);
            this.inputTab.Location = new System.Drawing.Point(12, 18);
            this.inputTab.Name = "inputTab";
            this.inputTab.SelectedIndex = 0;
            this.inputTab.Size = new System.Drawing.Size(556, 623);
            this.inputTab.TabIndex = 0;
            // 
            // personalInfoTab
            // 
            this.personalInfoTab.Controls.Add(this.groupBox1);
            this.personalInfoTab.Location = new System.Drawing.Point(4, 25);
            this.personalInfoTab.Name = "personalInfoTab";
            this.personalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.personalInfoTab.Size = new System.Drawing.Size(548, 594);
            this.personalInfoTab.TabIndex = 0;
            this.personalInfoTab.Text = "Personal Information";
            this.personalInfoTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstNameLbl);
            this.groupBox1.Controls.Add(this.addressTxt);
            this.groupBox1.Controls.Add(this.phoneNumberTxt);
            this.groupBox1.Controls.Add(this.addressLbl);
            this.groupBox1.Controls.Add(this.firstNameTxt);
            this.groupBox1.Controls.Add(this.phoneNumberLbl);
            this.groupBox1.Controls.Add(this.lastNameLbl);
            this.groupBox1.Controls.Add(this.emailTxt);
            this.groupBox1.Controls.Add(this.lastNameTxt);
            this.groupBox1.Controls.Add(this.emailLbl);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(25, 32);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(81, 17);
            this.firstNameLbl.TabIndex = 0;
            this.firstNameLbl.Text = "First Name*";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(117, 141);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(255, 22);
            this.addressTxt.TabIndex = 4;
            this.addressTxt.Click += new System.EventHandler(this.addressTxt_Click);
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Location = new System.Drawing.Point(117, 113);
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(255, 22);
            this.phoneNumberTxt.TabIndex = 3;
            this.phoneNumberTxt.Click += new System.EventHandler(this.phoneNumberTxt_Click);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(25, 144);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(60, 17);
            this.addressLbl.TabIndex = 0;
            this.addressLbl.Text = "Address";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(117, 29);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(255, 22);
            this.firstNameTxt.TabIndex = 0;
            this.firstNameTxt.Click += new System.EventHandler(this.firstNameTxt_Click);
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Location = new System.Drawing.Point(25, 116);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(86, 17);
            this.phoneNumberLbl.TabIndex = 0;
            this.phoneNumberLbl.Text = "Tel. Number";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(25, 60);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(81, 17);
            this.lastNameLbl.TabIndex = 0;
            this.lastNameLbl.Text = "Last Name*";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(117, 85);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(255, 22);
            this.emailTxt.TabIndex = 2;
            this.emailTxt.Click += new System.EventHandler(this.emailTxt_Click);
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(117, 57);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(255, 22);
            this.lastNameTxt.TabIndex = 1;
            this.lastNameTxt.Click += new System.EventHandler(this.lastNameTxt_Click);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(25, 88);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "Email";
            this.emailLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // accountInformationTab
            // 
            this.accountInformationTab.Controls.Add(this.groupBox2);
            this.accountInformationTab.Location = new System.Drawing.Point(4, 25);
            this.accountInformationTab.Name = "accountInformationTab";
            this.accountInformationTab.Padding = new System.Windows.Forms.Padding(3);
            this.accountInformationTab.Size = new System.Drawing.Size(548, 594);
            this.accountInformationTab.TabIndex = 1;
            this.accountInformationTab.Text = "Account Information";
            this.accountInformationTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.copyBtn);
            this.groupBox2.Controls.Add(this.genNumberBtn);
            this.groupBox2.Controls.Add(this.genPinBtn);
            this.groupBox2.Controls.Add(this.accountTypeCombo);
            this.groupBox2.Controls.Add(this.accountTypeLbl);
            this.groupBox2.Controls.Add(this.confirmPasswordLbl);
            this.groupBox2.Controls.Add(this.passwordLbl);
            this.groupBox2.Controls.Add(this.usernameLbl);
            this.groupBox2.Controls.Add(this.confirmPasswordTxt);
            this.groupBox2.Controls.Add(this.passwordTxt);
            this.groupBox2.Controls.Add(this.usernameTxt);
            this.groupBox2.Location = new System.Drawing.Point(18, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 208);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Information";
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(43, 96);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(88, 23);
            this.copyBtn.TabIndex = 5;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Visible = false;
            // 
            // genNumberBtn
            // 
            this.genNumberBtn.Location = new System.Drawing.Point(137, 96);
            this.genNumberBtn.Name = "genNumberBtn";
            this.genNumberBtn.Size = new System.Drawing.Size(143, 23);
            this.genNumberBtn.TabIndex = 5;
            this.genNumberBtn.Text = "Gen. Number";
            this.genNumberBtn.UseVisualStyleBackColor = true;
            this.genNumberBtn.Visible = false;
            this.genNumberBtn.Click += new System.EventHandler(this.genNumberBtn_Click);
            // 
            // genPinBtn
            // 
            this.genPinBtn.Location = new System.Drawing.Point(286, 96);
            this.genPinBtn.Name = "genPinBtn";
            this.genPinBtn.Size = new System.Drawing.Size(143, 23);
            this.genPinBtn.TabIndex = 5;
            this.genPinBtn.Text = "Gen. Pin";
            this.genPinBtn.UseVisualStyleBackColor = true;
            this.genPinBtn.Visible = false;
            this.genPinBtn.Click += new System.EventHandler(this.genPinBtn_Click);
            // 
            // accountTypeCombo
            // 
            this.accountTypeCombo.FormattingEnabled = true;
            this.accountTypeCombo.Location = new System.Drawing.Point(177, 128);
            this.accountTypeCombo.Name = "accountTypeCombo";
            this.accountTypeCombo.Size = new System.Drawing.Size(252, 24);
            this.accountTypeCombo.TabIndex = 4;
            this.accountTypeCombo.SelectedIndexChanged += new System.EventHandler(this.accountTypeCombo_SelectedIndexChanged);
            this.accountTypeCombo.Click += new System.EventHandler(this.accountTypeCombo_Click);
            // 
            // accountTypeLbl
            // 
            this.accountTypeLbl.AutoSize = true;
            this.accountTypeLbl.Location = new System.Drawing.Point(50, 131);
            this.accountTypeLbl.Name = "accountTypeLbl";
            this.accountTypeLbl.Size = new System.Drawing.Size(100, 17);
            this.accountTypeLbl.TabIndex = 1;
            this.accountTypeLbl.Text = "Account Type*";
            // 
            // confirmPasswordLbl
            // 
            this.confirmPasswordLbl.AutoSize = true;
            this.confirmPasswordLbl.Location = new System.Drawing.Point(50, 100);
            this.confirmPasswordLbl.Name = "confirmPasswordLbl";
            this.confirmPasswordLbl.Size = new System.Drawing.Size(126, 17);
            this.confirmPasswordLbl.TabIndex = 1;
            this.confirmPasswordLbl.Text = "Confirm Password*";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(50, 72);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(74, 17);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "Password*";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(50, 44);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(78, 17);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username*";
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.Location = new System.Drawing.Point(177, 97);
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.PasswordChar = '*';
            this.confirmPasswordTxt.Size = new System.Drawing.Size(252, 22);
            this.confirmPasswordTxt.TabIndex = 3;
            this.confirmPasswordTxt.Click += new System.EventHandler(this.confirmPasswordTxt_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(177, 69);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(252, 22);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.Click += new System.EventHandler(this.passwordTxt_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(177, 41);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(252, 22);
            this.usernameTxt.TabIndex = 1;
            this.usernameTxt.Click += new System.EventHandler(this.usernameTxt_Click);
            // 
            // fingerprintTab
            // 
            this.fingerprintTab.Controls.Add(this.groupBox3);
            this.fingerprintTab.Location = new System.Drawing.Point(4, 25);
            this.fingerprintTab.Name = "fingerprintTab";
            this.fingerprintTab.Padding = new System.Windows.Forms.Padding(3);
            this.fingerprintTab.Size = new System.Drawing.Size(548, 594);
            this.fingerprintTab.TabIndex = 2;
            this.fingerprintTab.Text = "Biometric Fingerprint Information";
            this.fingerprintTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fingerprint_preview_lbl);
            this.groupBox3.Controls.Add(this.FingerprintPreviewBox);
            this.groupBox3.Controls.Add(this.ReadFingerprintBtn);
            this.groupBox3.Controls.Add(this.AutoReadFingerprint_chk);
            this.groupBox3.Controls.Add(this.templatePathLbl);
            this.groupBox3.Controls.Add(this.imageFilePath);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.openTempFileBtn);
            this.groupBox3.Controls.Add(this.stringHashTxt);
            this.groupBox3.Controls.Add(this.copyHashBtn);
            this.groupBox3.Controls.Add(this.generateHashBtn);
            this.groupBox3.Location = new System.Drawing.Point(19, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 206);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Minatiuea Template Information";
            // 
            // fingerprint_preview_lbl
            // 
            this.fingerprint_preview_lbl.AutoSize = true;
            this.fingerprint_preview_lbl.Location = new System.Drawing.Point(33, 129);
            this.fingerprint_preview_lbl.Name = "fingerprint_preview_lbl";
            this.fingerprint_preview_lbl.Size = new System.Drawing.Size(129, 17);
            this.fingerprint_preview_lbl.TabIndex = 5;
            this.fingerprint_preview_lbl.Text = "Fingerprint Preview";
            // 
            // FingerprintPreviewBox
            // 
            this.FingerprintPreviewBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FingerprintPreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FingerprintPreviewBox.Location = new System.Drawing.Point(36, 150);
            this.FingerprintPreviewBox.Name = "FingerprintPreviewBox";
            this.FingerprintPreviewBox.Size = new System.Drawing.Size(400, 395);
            this.FingerprintPreviewBox.TabIndex = 8;
            this.FingerprintPreviewBox.TabStop = false;
            // 
            // ReadFingerprintBtn
            // 
            this.ReadFingerprintBtn.Location = new System.Drawing.Point(220, 103);
            this.ReadFingerprintBtn.Name = "ReadFingerprintBtn";
            this.ReadFingerprintBtn.Size = new System.Drawing.Size(178, 32);
            this.ReadFingerprintBtn.TabIndex = 7;
            this.ReadFingerprintBtn.Text = "Capture Fingerprint";
            this.ReadFingerprintBtn.UseVisualStyleBackColor = true;
            this.ReadFingerprintBtn.Click += new System.EventHandler(this.ReadFingerprintBtn_Click);
            // 
            // AutoReadFingerprint_chk
            // 
            this.AutoReadFingerprint_chk.AutoSize = true;
            this.AutoReadFingerprint_chk.Location = new System.Drawing.Point(36, 110);
            this.AutoReadFingerprint_chk.Name = "AutoReadFingerprint_chk";
            this.AutoReadFingerprint_chk.Size = new System.Drawing.Size(169, 21);
            this.AutoReadFingerprint_chk.TabIndex = 6;
            this.AutoReadFingerprint_chk.Text = "Auto Read Fingerprint";
            this.AutoReadFingerprint_chk.UseVisualStyleBackColor = true;
            this.AutoReadFingerprint_chk.CheckedChanged += new System.EventHandler(this.AutoReadFingerprint_chk_CheckedChanged);
            // 
            // templatePathLbl
            // 
            this.templatePathLbl.AutoSize = true;
            this.templatePathLbl.Location = new System.Drawing.Point(33, 107);
            this.templatePathLbl.Name = "templatePathLbl";
            this.templatePathLbl.Size = new System.Drawing.Size(37, 17);
            this.templatePathLbl.TabIndex = 5;
            this.templatePathLbl.Text = "Path";
            // 
            // imageFilePath
            // 
            this.imageFilePath.Location = new System.Drawing.Point(76, 104);
            this.imageFilePath.Name = "imageFilePath";
            this.imageFilePath.Size = new System.Drawing.Size(254, 22);
            this.imageFilePath.TabIndex = 4;
            this.imageFilePath.Click += new System.EventHandler(this.templateFilePath_Click);
            this.imageFilePath.TextChanged += new System.EventHandler(this.imageFilePath_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "String Hash";
            // 
            // openTempFileBtn
            // 
            this.openTempFileBtn.Location = new System.Drawing.Point(336, 100);
            this.openTempFileBtn.Name = "openTempFileBtn";
            this.openTempFileBtn.Size = new System.Drawing.Size(145, 31);
            this.openTempFileBtn.TabIndex = 5;
            this.openTempFileBtn.Text = "Open Image  File";
            this.openTempFileBtn.UseVisualStyleBackColor = true;
            this.openTempFileBtn.Click += new System.EventHandler(this.openTempFileBtn_Click);
            // 
            // stringHashTxt
            // 
            this.stringHashTxt.Enabled = false;
            this.stringHashTxt.Location = new System.Drawing.Point(121, 24);
            this.stringHashTxt.Name = "stringHashTxt";
            this.stringHashTxt.Size = new System.Drawing.Size(360, 22);
            this.stringHashTxt.TabIndex = 1;
            // 
            // copyHashBtn
            // 
            this.copyHashBtn.Location = new System.Drawing.Point(185, 52);
            this.copyHashBtn.Name = "copyHashBtn";
            this.copyHashBtn.Size = new System.Drawing.Size(145, 35);
            this.copyHashBtn.TabIndex = 2;
            this.copyHashBtn.Text = "Copy Hash";
            this.copyHashBtn.UseVisualStyleBackColor = true;
            this.copyHashBtn.Click += new System.EventHandler(this.copyHashBtn_Click);
            // 
            // generateHashBtn
            // 
            this.generateHashBtn.Location = new System.Drawing.Point(336, 52);
            this.generateHashBtn.Name = "generateHashBtn";
            this.generateHashBtn.Size = new System.Drawing.Size(145, 35);
            this.generateHashBtn.TabIndex = 3;
            this.generateHashBtn.Text = "Gereate Hash";
            this.generateHashBtn.UseVisualStyleBackColor = true;
            this.generateHashBtn.Click += new System.EventHandler(this.genereateHashBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(356, 647);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(101, 36);
            this.doneBtn.TabIndex = 5;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(463, 647);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(101, 36);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // openTemplateDialog
            // 
            this.openTemplateDialog.FileName = "openTemplateDialog";
            this.openTemplateDialog.Filter = "Image Files (*.png *.jpg *.bmp) | *.tif; *.png; *.jpg; *.bmp ";
            this.openTemplateDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openTemplateDialog_FileOk);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(31, 657);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(138, 17);
            this.errorLbl.TabIndex = 7;
            this.errorLbl.Text = "Field(s) has error(s).";
            this.errorLbl.Visible = false;
            // 
            // usernameErrorTooltip
            // 
            this.usernameErrorTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.usernameErrorTooltip.ToolTipTitle = "Username Error.";
            this.usernameErrorTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.usernameErrorTooltip_Popup);
            // 
            // passwordErrorTooltip
            // 
            this.passwordErrorTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.passwordErrorTooltip.ToolTipTitle = "Password Error";
            // 
            // accountTypeErrorTooltip
            // 
            this.accountTypeErrorTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.accountTypeErrorTooltip.ToolTipTitle = "Account Type Error";
            // 
            // templatePathErrorTooltip
            // 
            this.templatePathErrorTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.templatePathErrorTooltip.ToolTipTitle = "Template Path Error";
            // 
            // fieldTooltip
            // 
            this.fieldTooltip.ToolTipTitle = "Field has errors.";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(582, 695);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.inputTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "AccountForm";
            this.Text = "Setting Up Account";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.inputTab.ResumeLayout(false);
            this.personalInfoTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.accountInformationTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.fingerprintTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FingerprintPreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl inputTab;
        private System.Windows.Forms.TabPage personalInfoTab;
        private System.Windows.Forms.TabPage accountInformationTab;
        private System.Windows.Forms.TabPage fingerprintTab;
        private System.Windows.Forms.TextBox phoneNumberTxt;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox accountTypeCombo;
        private System.Windows.Forms.Label accountTypeLbl;
        private System.Windows.Forms.Label confirmPasswordLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox confirmPasswordTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Button generateHashBtn;
        private System.Windows.Forms.TextBox stringHashTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openTemplateDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label templatePathLbl;
        private System.Windows.Forms.TextBox imageFilePath;
        private System.Windows.Forms.Button openTempFileBtn;
        private System.Windows.Forms.Button copyHashBtn;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.ToolTip usernameErrorTooltip;
        private System.Windows.Forms.ToolTip passwordErrorTooltip;
        private System.Windows.Forms.ToolTip accountTypeErrorTooltip;
        private System.Windows.Forms.ToolTip templatePathErrorTooltip;
        private System.Windows.Forms.ToolTip fieldTooltip;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button genNumberBtn;
        private System.Windows.Forms.Button genPinBtn;
        private System.Windows.Forms.Button ReadFingerprintBtn;
        private System.Windows.Forms.CheckBox AutoReadFingerprint_chk;
        private System.Windows.Forms.PictureBox FingerprintPreviewBox;
        private System.Windows.Forms.Label fingerprint_preview_lbl;
    }
}