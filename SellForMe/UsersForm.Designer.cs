namespace SellForMe
{
    partial class UsersForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FullnameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.ConfirmPasswordTexbox = new System.Windows.Forms.TextBox();
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSysAdmin = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAccounts = new System.Windows.Forms.CheckBox();
            this.chkHumanResourceManager = new System.Windows.Forms.CheckBox();
            this.chkStoreManager = new System.Windows.Forms.CheckBox();
            this.chkSalesRep = new System.Windows.Forms.CheckBox();
            this.ShowPass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 56);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fullname";
            // 
            // FullnameTextbox
            // 
            this.FullnameTextbox.Location = new System.Drawing.Point(41, 101);
            this.FullnameTextbox.Name = "FullnameTextbox";
            this.FullnameTextbox.Size = new System.Drawing.Size(331, 31);
            this.FullnameTextbox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(41, 169);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(331, 31);
            this.UsernameTextbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(41, 237);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(331, 31);
            this.PasswordTextbox.TabIndex = 2;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Confirm Password";
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CreateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUserButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserButton.ForeColor = System.Drawing.Color.White;
            this.CreateUserButton.Location = new System.Drawing.Point(220, 502);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(152, 40);
            this.CreateUserButton.TabIndex = 4;
            this.CreateUserButton.Text = "CREATE USER";
            this.CreateUserButton.UseVisualStyleBackColor = false;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // ConfirmPasswordTexbox
            // 
            this.ConfirmPasswordTexbox.Location = new System.Drawing.Point(41, 297);
            this.ConfirmPasswordTexbox.Name = "ConfirmPasswordTexbox";
            this.ConfirmPasswordTexbox.Size = new System.Drawing.Size(331, 31);
            this.ConfirmPasswordTexbox.TabIndex = 3;
            this.ConfirmPasswordTexbox.UseSystemPasswordChar = true;
            this.ConfirmPasswordTexbox.Leave += new System.EventHandler(this.ConfirmPasswordTexbox_Leave);
            // 
            // DgvUsers
            // 
            this.DgvUsers.AllowUserToAddRows = false;
            this.DgvUsers.AllowUserToDeleteRows = false;
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Fullname,
            this.Role});
            this.DgvUsers.Dock = System.Windows.Forms.DockStyle.Right;
            this.DgvUsers.Location = new System.Drawing.Point(393, 56);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.ReadOnly = true;
            this.DgvUsers.RowHeadersWidth = 45;
            this.DgvUsers.Size = new System.Drawing.Size(416, 507);
            this.DgvUsers.TabIndex = 7;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 110;
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.MinimumWidth = 6;
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            this.Fullname.Width = 150;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 110;
            // 
            // chkSysAdmin
            // 
            this.chkSysAdmin.AutoSize = true;
            this.chkSysAdmin.Location = new System.Drawing.Point(8, 37);
            this.chkSysAdmin.Name = "chkSysAdmin";
            this.chkSysAdmin.Size = new System.Drawing.Size(110, 29);
            this.chkSysAdmin.TabIndex = 0;
            this.chkSysAdmin.Text = "SysAdmin";
            this.chkSysAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSysAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAccounts);
            this.groupBox1.Controls.Add(this.chkHumanResourceManager);
            this.groupBox1.Controls.Add(this.chkStoreManager);
            this.groupBox1.Controls.Add(this.chkSalesRep);
            this.groupBox1.Controls.Add(this.chkSysAdmin);
            this.groupBox1.Location = new System.Drawing.Point(41, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 159);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Privilleges";
            // 
            // chkAccounts
            // 
            this.chkAccounts.AutoSize = true;
            this.chkAccounts.Location = new System.Drawing.Point(8, 77);
            this.chkAccounts.Name = "chkAccounts";
            this.chkAccounts.Size = new System.Drawing.Size(104, 29);
            this.chkAccounts.TabIndex = 2;
            this.chkAccounts.Text = "Accounts";
            this.chkAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAccounts.UseVisualStyleBackColor = true;
            // 
            // chkHumanResourceManager
            // 
            this.chkHumanResourceManager.AutoSize = true;
            this.chkHumanResourceManager.Location = new System.Drawing.Point(8, 115);
            this.chkHumanResourceManager.Name = "chkHumanResourceManager";
            this.chkHumanResourceManager.Size = new System.Drawing.Size(240, 29);
            this.chkHumanResourceManager.TabIndex = 4;
            this.chkHumanResourceManager.Text = "Human Resource Manager";
            this.chkHumanResourceManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHumanResourceManager.UseVisualStyleBackColor = true;
            // 
            // chkStoreManager
            // 
            this.chkStoreManager.AutoSize = true;
            this.chkStoreManager.Location = new System.Drawing.Point(124, 77);
            this.chkStoreManager.Name = "chkStoreManager";
            this.chkStoreManager.Size = new System.Drawing.Size(147, 29);
            this.chkStoreManager.TabIndex = 3;
            this.chkStoreManager.Text = "Store Manager";
            this.chkStoreManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkStoreManager.UseVisualStyleBackColor = true;
            // 
            // chkSalesRep
            // 
            this.chkSalesRep.AutoSize = true;
            this.chkSalesRep.Location = new System.Drawing.Point(124, 37);
            this.chkSalesRep.Name = "chkSalesRep";
            this.chkSalesRep.Size = new System.Drawing.Size(191, 29);
            this.chkSalesRep.TabIndex = 1;
            this.chkSalesRep.Text = "Sales Representative";
            this.chkSalesRep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSalesRep.UseVisualStyleBackColor = true;
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPass.Location = new System.Drawing.Point(241, 209);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(129, 24);
            this.ShowPass.TabIndex = 10;
            this.ShowPass.Text = "show password";
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(809, 563);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvUsers);
            this.Controls.Add(this.CreateUserButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConfirmPasswordTexbox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FullnameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.UsersForm_Activated);
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FullnameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.TextBox ConfirmPasswordTexbox;
        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.CheckBox chkSysAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAccounts;
        private System.Windows.Forms.CheckBox chkHumanResourceManager;
        private System.Windows.Forms.CheckBox chkStoreManager;
        private System.Windows.Forms.CheckBox chkSalesRep;
        private System.Windows.Forms.CheckBox ShowPass;
    }
}