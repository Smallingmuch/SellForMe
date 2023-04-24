namespace SellForMe
{
    partial class ManageStoresForm
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
            this.StoresLst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditStoreButton = new System.Windows.Forms.Button();
            this.DeleteStore = new System.Windows.Forms.Button();
            this.BackUpStore = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StoresLst
            // 
            this.StoresLst.FormattingEnabled = true;
            this.StoresLst.ItemHeight = 25;
            this.StoresLst.Location = new System.Drawing.Point(12, 41);
            this.StoresLst.Name = "StoresLst";
            this.StoresLst.Size = new System.Drawing.Size(487, 254);
            this.StoresLst.TabIndex = 0;
            this.StoresLst.SelectedIndexChanged += new System.EventHandler(this.StoresLst_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stores";
            // 
            // EditStoreButton
            // 
            this.EditStoreButton.BackColor = System.Drawing.Color.White;
            this.EditStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStoreButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStoreButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EditStoreButton.Location = new System.Drawing.Point(55, 358);
            this.EditStoreButton.Name = "EditStoreButton";
            this.EditStoreButton.Size = new System.Drawing.Size(118, 40);
            this.EditStoreButton.TabIndex = 4;
            this.EditStoreButton.Text = "Edit Store";
            this.EditStoreButton.UseVisualStyleBackColor = false;
            this.EditStoreButton.Click += new System.EventHandler(this.EditStoreButton_Click);
            // 
            // DeleteStore
            // 
            this.DeleteStore.BackColor = System.Drawing.Color.White;
            this.DeleteStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteStore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DeleteStore.Location = new System.Drawing.Point(179, 358);
            this.DeleteStore.Name = "DeleteStore";
            this.DeleteStore.Size = new System.Drawing.Size(128, 40);
            this.DeleteStore.TabIndex = 4;
            this.DeleteStore.Text = "Delete Store";
            this.DeleteStore.UseVisualStyleBackColor = false;
            // 
            // BackUpStore
            // 
            this.BackUpStore.BackColor = System.Drawing.Color.White;
            this.BackUpStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackUpStore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackUpStore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BackUpStore.Location = new System.Drawing.Point(313, 358);
            this.BackUpStore.Name = "BackUpStore";
            this.BackUpStore.Size = new System.Drawing.Size(128, 40);
            this.BackUpStore.TabIndex = 4;
            this.BackUpStore.Text = "Backup DB";
            this.BackUpStore.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(382, 31);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Device...";
            // 
            // ManageStoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(515, 420);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BackUpStore);
            this.Controls.Add(this.DeleteStore);
            this.Controls.Add(this.EditStoreButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StoresLst);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageStoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Manager";
            this.Load += new System.EventHandler(this.ManageStoresForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StoresLst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditStoreButton;
        private System.Windows.Forms.Button DeleteStore;
        private System.Windows.Forms.Button BackUpStore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}