using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                AccountInformation adminAccount = (from account in db.AccountInformations
                                                   where account.AccountNumber == usernameTxt.Text &&
                                                         account.TypeID.Equals(1)
                                                   select account).FirstOrDefault();
                
                if (adminAccount == null)
                {
                    MessageBox.Show("Account doesn't exist. Try again.", "Account doesn't exist", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else if(adminAccount.AccountUsername != passwordTxt.Text)
                {
                    MessageBox.Show("Password incorrect, Try again.", "Alert! Enterd Password Wrong",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else // If User Authenticated
                {
                    dash.Show();
                    this.Close();
                }
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text.Length > 0)
                LoginBtn.Enabled = true;
            else
                LoginBtn.Enabled = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
