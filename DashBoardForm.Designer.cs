namespace LeafSecurity
{
    partial class DashBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            this.accountCounterLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchQueryTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.advSearchBtn = new System.Windows.Forms.Button();
            this.accountList = new System.Windows.Forms.ListView();
            this.idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fullNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accountTypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasTemplateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accountListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editAccountStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccountStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exploreApplicationPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountBtn = new System.Windows.Forms.Button();
            this.refreshTableBtn = new System.Windows.Forms.Button();
            this.accountListContextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountCounterLbl
            // 
            this.accountCounterLbl.AutoSize = true;
            this.accountCounterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountCounterLbl.Location = new System.Drawing.Point(25, 47);
            this.accountCounterLbl.Name = "accountCounterLbl";
            this.accountCounterLbl.Size = new System.Drawing.Size(155, 25);
            this.accountCounterLbl.TabIndex = 0;
            this.accountCounterLbl.Text = "No. (Account): #";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Query search here:";
            // 
            // searchQueryTxt
            // 
            this.searchQueryTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchQueryTxt.Location = new System.Drawing.Point(364, 80);
            this.searchQueryTxt.Name = "searchQueryTxt";
            this.searchQueryTxt.Size = new System.Drawing.Size(325, 22);
            this.searchQueryTxt.TabIndex = 8;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.searchBtn.Location = new System.Drawing.Point(695, 75);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 30);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // advSearchBtn
            // 
            this.advSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.advSearchBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advSearchBtn.Location = new System.Drawing.Point(636, 111);
            this.advSearchBtn.Name = "advSearchBtn";
            this.advSearchBtn.Size = new System.Drawing.Size(134, 32);
            this.advSearchBtn.TabIndex = 7;
            this.advSearchBtn.Text = "Adv. Search";
            this.advSearchBtn.UseVisualStyleBackColor = true;
            // 
            // accountList
            // 
            this.accountList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.accountList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHeader,
            this.fullNameHeader,
            this.accountTypeHeader,
            this.addressHeader,
            this.phoneNumberHeader,
            this.hasTemplateHeader});
            this.accountList.ContextMenuStrip = this.accountListContextMenu;
            this.accountList.FullRowSelect = true;
            this.accountList.GridLines = true;
            this.accountList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.accountList.Location = new System.Drawing.Point(12, 149);
            this.accountList.MultiSelect = false;
            this.accountList.Name = "accountList";
            this.accountList.Size = new System.Drawing.Size(758, 392);
            this.accountList.TabIndex = 1;
            this.accountList.UseCompatibleStateImageBehavior = false;
            this.accountList.View = System.Windows.Forms.View.Details;
            this.accountList.SelectedIndexChanged += new System.EventHandler(this.accountList_SelectedIndexChanged);
            this.accountList.DoubleClick += new System.EventHandler(this.accountList_DoubleClick);
            // 
            // idHeader
            // 
            this.idHeader.Text = "ID";
            this.idHeader.Width = 80;
            // 
            // fullNameHeader
            // 
            this.fullNameHeader.Text = "Full Name";
            this.fullNameHeader.Width = 200;
            // 
            // accountTypeHeader
            // 
            this.accountTypeHeader.Text = "Account Type";
            this.accountTypeHeader.Width = 120;
            // 
            // addressHeader
            // 
            this.addressHeader.Text = "Address";
            this.addressHeader.Width = 120;
            // 
            // phoneNumberHeader
            // 
            this.phoneNumberHeader.Text = "Phone No.";
            this.phoneNumberHeader.Width = 100;
            // 
            // hasTemplateHeader
            // 
            this.hasTemplateHeader.Text = "Has Template";
            this.hasTemplateHeader.Width = 100;
            // 
            // accountListContextMenu
            // 
            this.accountListContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.accountListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAccountStripMenuItem,
            this.removeAccountStripMenuItem});
            this.accountListContextMenu.Name = "accountListContextMenu";
            this.accountListContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.accountListContextMenu.Size = new System.Drawing.Size(191, 52);
            this.accountListContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editAccountStripMenuItem
            // 
            this.editAccountStripMenuItem.Name = "editAccountStripMenuItem";
            this.editAccountStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.editAccountStripMenuItem.Text = "Edit Account";
            this.editAccountStripMenuItem.Click += new System.EventHandler(this.editAccountStripMenuItem_Click);
            // 
            // removeAccountStripMenuItem
            // 
            this.removeAccountStripMenuItem.Name = "removeAccountStripMenuItem";
            this.removeAccountStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.removeAccountStripMenuItem.Text = "Remove Account";
            this.removeAccountStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.removeAccountStripMenuItem.Click += new System.EventHandler(this.removeAccountStripMenuItem_Click);
            // 
            // viewLogBtn
            // 
            this.viewLogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewLogBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLogBtn.Location = new System.Drawing.Point(496, 111);
            this.viewLogBtn.Name = "viewLogBtn";
            this.viewLogBtn.Size = new System.Drawing.Size(134, 32);
            this.viewLogBtn.TabIndex = 6;
            this.viewLogBtn.Text = "View Log";
            this.viewLogBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem,
            this.editAccountToolStripMenuItem,
            this.removeAccountToolStripMenuItem,
            this.filterAccountToolStripMenuItem,
            this.toolStripSeparator1,
            this.searchToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.addAccountToolStripMenuItem.Text = "Add Account";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);
            // 
            // editAccountToolStripMenuItem
            // 
            this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
            this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.editAccountToolStripMenuItem.Text = "Edit Account";
            // 
            // removeAccountToolStripMenuItem
            // 
            this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
            this.removeAccountToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.removeAccountToolStripMenuItem.Text = "Remove Account";
            this.removeAccountToolStripMenuItem.Click += new System.EventHandler(this.removeAccountToolStripMenuItem_Click);
            // 
            // filterAccountToolStripMenuItem
            // 
            this.filterAccountToolStripMenuItem.Name = "filterAccountToolStripMenuItem";
            this.filterAccountToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.filterAccountToolStripMenuItem.Text = "Filter Account";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLogToolStripMenuItem,
            this.advancedSearchToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // viewLogToolStripMenuItem
            // 
            this.viewLogToolStripMenuItem.Name = "viewLogToolStripMenuItem";
            this.viewLogToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.viewLogToolStripMenuItem.Text = "View Log";
            // 
            // advancedSearchToolStripMenuItem
            // 
            this.advancedSearchToolStripMenuItem.Name = "advancedSearchToolStripMenuItem";
            this.advancedSearchToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.advancedSearchToolStripMenuItem.Text = "Advanced Search";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exploreApplicationPathToolStripMenuItem,
            this.settingsToolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exploreApplicationPathToolStripMenuItem
            // 
            this.exploreApplicationPathToolStripMenuItem.Name = "exploreApplicationPathToolStripMenuItem";
            this.exploreApplicationPathToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.exploreApplicationPathToolStripMenuItem.Text = "Explore Application Path";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.settingsToolStripMenuItem1.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(125, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.Location = new System.Drawing.Point(12, 113);
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Size = new System.Drawing.Size(87, 32);
            this.addAccountBtn.TabIndex = 12;
            this.addAccountBtn.Text = "Add";
            this.addAccountBtn.UseVisualStyleBackColor = true;
            this.addAccountBtn.Click += new System.EventHandler(this.addAccountBtn_Click);
            // 
            // refreshTableBtn
            // 
            this.refreshTableBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshTableBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshTableBtn.Location = new System.Drawing.Point(265, 111);
            this.refreshTableBtn.Name = "refreshTableBtn";
            this.refreshTableBtn.Size = new System.Drawing.Size(225, 32);
            this.refreshTableBtn.TabIndex = 6;
            this.refreshTableBtn.Text = "Refresh";
            this.refreshTableBtn.UseVisualStyleBackColor = true;
            this.refreshTableBtn.Click += new System.EventHandler(this.refreshTableBtn_Click);
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.addAccountBtn);
            this.Controls.Add(this.accountList);
            this.Controls.Add(this.refreshTableBtn);
            this.Controls.Add(this.viewLogBtn);
            this.Controls.Add(this.advSearchBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchQueryTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountCounterLbl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "DashBoardForm";
            this.Text = "LeafSecurity (Admin)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashBoardForm_FormClosed);
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
            this.accountListContextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountCounterLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchQueryTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button advSearchBtn;
        private System.Windows.Forms.ListView accountList;
        private System.Windows.Forms.Button viewLogBtn;
        private System.Windows.Forms.ColumnHeader fullNameHeader;
        private System.Windows.Forms.ColumnHeader accountTypeHeader;
        private System.Windows.Forms.ColumnHeader addressHeader;
        private System.Windows.Forms.ColumnHeader phoneNumberHeader;
        private System.Windows.Forms.ColumnHeader hasTemplateHeader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exploreApplicationPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader idHeader;
        private System.Windows.Forms.ContextMenuStrip accountListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editAccountStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAccountStripMenuItem;
        private System.Windows.Forms.Button addAccountBtn;
        private System.Windows.Forms.Button refreshTableBtn;
    }
}