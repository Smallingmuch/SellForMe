namespace SellForMe
{
    partial class DataBaseConnectivity
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
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.ConnectDb = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConnectStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblConnectStatus);
            this.panel1.Controls.Add(this.ShowPassword);
            this.panel1.Controls.Add(this.linkLabelLogin);
            this.panel1.Controls.Add(this.ConnectDb);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ServerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 274);
            this.panel1.TabIndex = 1;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ShowPassword.Location = new System.Drawing.Point(246, 141);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(62, 24);
            this.ShowPassword.TabIndex = 6;
            this.ShowPassword.Text = "show";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabelLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelLogin.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelLogin.Location = new System.Drawing.Point(254, 226);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(59, 25);
            this.linkLabelLogin.TabIndex = 5;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Login";
            this.linkLabelLogin.VisitedLinkColor = System.Drawing.SystemColors.HotTrack;
            // 
            // ConnectDb
            // 
            this.ConnectDb.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ConnectDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectDb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectDb.ForeColor = System.Drawing.Color.White;
            this.ConnectDb.Location = new System.Drawing.Point(21, 218);
            this.ConnectDb.Name = "ConnectDb";
            this.ConnectDb.Size = new System.Drawing.Size(129, 40);
            this.ConnectDb.TabIndex = 4;
            this.ConnectDb.Text = "CONNECT";
            this.ConnectDb.UseVisualStyleBackColor = false;
            this.ConnectDb.Click += new System.EventHandler(this.ConnectDb_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Password.Location = new System.Drawing.Point(21, 168);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(289, 31);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Username.Location = new System.Drawing.Point(21, 105);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(289, 31);
            this.Username.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // ServerName
            // 
            this.ServerName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ServerName.Location = new System.Drawing.Point(21, 39);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(289, 31);
            this.ServerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Name";
            // 
            // lblConnectStatus
            // 
            this.lblConnectStatus.AutoSize = true;
            this.lblConnectStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblConnectStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblConnectStatus.Location = new System.Drawing.Point(239, 5);
            this.lblConnectStatus.Name = "lblConnectStatus";
            this.lblConnectStatus.Size = new System.Drawing.Size(88, 20);
            this.lblConnectStatus.TabIndex = 7;
            this.lblConnectStatus.Text = "connecting...";
            this.lblConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConnectStatus.Visible = false;
            // 
            // DataBaseConnectivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 306);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DataBaseConnectivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Database";
            this.Load += new System.EventHandler(this.DataBaseConnectivity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConnectDb;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Label lblConnectStatus;
    }
}