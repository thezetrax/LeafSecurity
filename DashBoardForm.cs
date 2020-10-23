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
    public partial class DashBoardForm : Form
    {
        AccountForm accountForm;
        private bool fingerprint_device_connected = false;

        // detect weather fingerprint device connected
        public void fp_device_connected(bool isConnected)
        {
            fingerprint_device_connected = isConnected;
        }

        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void DashBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            populateAccountList();
            accountForm = new AccountForm();
        }

        // Loads accountListView from database
        private void populateAccountList()
        {
            using (LeafSecurityEntities db = new LeafSecurityEntities())
            {
                IEnumerable<AccountInformation> accounts = from account in db.AccountInformations
                                                           select account;

                foreach (AccountInformation account in accounts)
                {
                    // Getting Account Type
                    AccountType accType = (from aType in db.AccountTypes
                                           select aType).First(a => a.TypeID == account.TypeID);

                    // Getting User Information
                    UserInformation userInfo = (from user in db.UserInformations
                                                where user.AccountID == account.AccountID
                                                select user).First(a => a.AccountID == account.AccountID);

                    // Getting FingerprintTemplate
                    IEnumerable<FingerprintTemplate> tFingerprint = (from tFinger in db.FingerprintTemplates
                                                                     where tFinger.AccountID == account.AccountID
                                                                     select tFinger);

                    ListViewItem accountItem = new ListViewItem();
                    accountItem.Text = account.AccountID.ToString();

                    ListViewItem.ListViewSubItemCollection accountSubItemCollection
                        = new ListViewItem.ListViewSubItemCollection(accountItem);

                    accountSubItemCollection.Add(userInfo.FirstName + " " + userInfo.LastName);
                    accountSubItemCollection.Add(accType.TypeName);
                    accountSubItemCollection.Add(userInfo.Address);
                    accountSubItemCollection.Add(userInfo.PhoneNumber);

                    if (tFingerprint.Count().Equals(0))
                    {
                        accountSubItemCollection.Add("No");
                    }
                    else
                    {
                        accountSubItemCollection.Add("Yes");
                    }

                    accountList.Items.Add(accountItem);
                }
            }
        }

        private void populateAccountList(string keyword)
        {
            keyword = keyword.ToLower();
            using (LeafSecurityEntities db = new LeafSecurityEntities())
            {
                IEnumerable<AccountInformation> accounts = from account in db.AccountInformations
                                                           where account.AccountNumber.Contains(keyword)
                                                           || account.AccountPinCode.Contains(keyword)
                                                           || account.AccountID.ToString().Contains(keyword)
                                                           select account;

                IEnumerable<AccountInformation> users = from user in db.UserInformations
                                                        where user.FirstName.ToLower().Contains(keyword)
                                                        || user.LastName.ToLower().Contains(keyword)
                                                        || user.Email.ToLower().Contains(keyword)
                                                        || user.PhoneNumber.ToLower().Contains(keyword)
                                                        || user.Address.ToLower().Contains(keyword)
                                                        select user.AccountInformation;

                foreach (AccountInformation account in accounts.Union(users))
                {
                    // Getting Account Type
                    AccountType accType = (from aType in db.AccountTypes
                                           select aType).First(a => a.TypeID == account.TypeID);

                    // Getting User Information
                    UserInformation userInfo = (from user in db.UserInformations
                                                //where user.AccountID == account.AccountID
                                                select user).First(a => a.AccountID == account.AccountID);

                    // Getting FingerprintTemplate
                    IEnumerable<FingerprintTemplate> tFingerprint = (from tFinger in db.FingerprintTemplates
                                                                     where tFinger.AccountID == account.AccountID
                                                                     select tFinger);

                    ListViewItem accountItem = new ListViewItem();
                    accountItem.Text = account.AccountID.ToString();

                    ListViewItem.ListViewSubItemCollection accountSubItemCollection
                        = new ListViewItem.ListViewSubItemCollection(accountItem);

                    accountSubItemCollection.Add(userInfo.FirstName + " " + userInfo.LastName);
                    accountSubItemCollection.Add(accType.TypeName);
                    accountSubItemCollection.Add(userInfo.Address);
                    accountSubItemCollection.Add(userInfo.PhoneNumber);

                    if (tFingerprint.Count().Equals(0))
                    {
                        accountSubItemCollection.Add("No");
                    }
                    else
                    {
                        accountSubItemCollection.Add("Yes");
                    }

                    accountList.Items.Add(accountItem);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void accountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountList.SelectedItems.Count == 0)
            {
                accountList.ContextMenuStrip.Enabled = false;
            }
            else
            {
                accountList.ContextMenuStrip.Enabled = true;
            }
        }

        private void editAccountStripMenuItem_Click(object sender, EventArgs e)
        {
            editAccount();
        }

        private void editAccount()
        {
            Console.WriteLine("Selected (Editing) Indices: {0}", accountList.SelectedIndices[0]);
            if (accountList.SelectedIndices.Count.Equals(0))
            {
                return;
            }

            ListViewItem selectedItem = accountList.SelectedItems[0];
            int accID = Convert.ToInt32(selectedItem.Text);
            AccountInformation selectedAccount;

            using (LeafSecurityEntities db = new LeafSecurityEntities())
            {
                selectedAccount = (from acc in db.AccountInformations
                                   where acc.AccountID.Equals(accID)
                                   select acc).FirstOrDefault();
            }

            AccountForm accForm = new AccountForm(selectedAccount);
            accForm.Show();
        }

        private void removeAccountStripMenuItem_Click(object sender, EventArgs e)
        {
            removeSelectedAccount();
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(accountForm.IsDisposed)
            {
                accountForm = new AccountForm();
                accountForm.Show(this);
            } else
            {
                accountForm.Show();
                accountForm.BringToFront();
            }
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            if (accountForm.IsDisposed)
            {
                accountForm = new AccountForm();
                accountForm.Show(this);
            }
            else
            {
                accountForm.Show();
                accountForm.BringToFront();
            }
        }

        private void refreshTableBtn_Click(object sender, EventArgs e)
        {
            refreshTableBtn.Text = "Refresh";
            accountList.Items.Clear();
            populateAccountList();
        }

        private void removeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeSelectedAccount();
        }

        public void removeSelectedAccount()
        {
            Console.WriteLine("Selected Indices: {0}", accountList.SelectedIndices[0]);
            if (accountList.SelectedIndices.Count.Equals(0))
            {
                return;
            }
            ListViewItem selectedItem = accountList.SelectedItems[0];
            int accID = Convert.ToInt32(selectedItem.Text);
            DialogResult res = MessageBox.Show(
                                    String.Format(
                                        "Do you want to remove {0}'s account?",
                                        selectedItem.SubItems[1].Text),
                                    "Are you sure?",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            // If 'No' do not remove
            if (res == DialogResult.No)
                return;


            try
            {
                bool removedAccount = removeAccount(accID);
                if (removedAccount)
                {
                    MessageBox.Show(
                        String.Format(
                            "{0}'s Account is Removed?",
                            selectedItem.SubItems[1].Text),
                        "Removed account",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    accountList.Items.Clear();
                    populateAccountList();
                }
            } catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Exception Occured!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private bool removeAccount(int accountID)
        {
            using (LeafSecurityEntities db = new LeafSecurityEntities())
            {
                IEnumerable<AccountInformation> accounts = from acc in db.AccountInformations
                                                           where acc.AccountID.Equals(accountID)
                                                           select acc;
                // If there are no accounts
                if (accounts.Count().Equals(0))
                    return false;

                AccountInformation account = accounts.First();
                
                // Disabling Removing Main Admin Account
                if (account.AccountID.Equals(1))
                    throw new Exception("Can not delete default admin account.");

                UserInformation userInfo = (from user in db.UserInformations
                                            where user.AccountID.Equals(account.AccountID)
                                            select user).First();

                IEnumerable<FingerprintTemplate> fTemplates = (from fTemp in db.FingerprintTemplates
                                                               where fTemp.AccountID.Equals(account.AccountID)
                                                               select fTemp);
                // If templates exists for this account.
                if (!fTemplates.Count().Equals(0))
                {

                    foreach (FingerprintTemplate fTemplate in fTemplates)
                    {
                        int minId = fTemplate.MinutiaeTemplateID;
                        db.FingerprintTemplates.Remove(fTemplate);
                        db.SaveChanges();
                        MinutiaeTemplatePath mTempPath = (from mPath in db.MinutiaeTemplatePaths
                                                          where mPath.ID.Equals(minId)
                                                          select mPath).First();
                        db.MinutiaeTemplatePaths.Remove(mTempPath);
                        db.SaveChanges();
                    }
                }

                // removing user information
                db.UserInformations.Remove(userInfo);
                db.SaveChanges();

                // removing user account
                db.AccountInformations.Remove(account);
                db.SaveChanges();
            }

            return true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            refreshTableBtn.Text = "Cancel Search";
            accountList.Items.Clear();
            populateAccountList(searchQueryTxt.Text);
        }

        private void accountList_DoubleClick(object sender, EventArgs e)
        {
            editAccount();
        }
    }
}
