namespace SellForMe
{
    partial class ImportStockForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SheetsCbo = new System.Windows.Forms.ComboBox();
            this.AddStockButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ImportStockButton = new System.Windows.Forms.Button();
            this.StockPathTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSavedItems = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAddingItems = new System.Windows.Forms.Label();
            this.DgvRowCount = new System.Windows.Forms.Label();
            this.ImportStockGrid = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ExistingItemNames = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExistingItem = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportStockGrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SheetsCbo);
            this.panel1.Controls.Add(this.AddStockButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ImportStockButton);
            this.panel1.Controls.Add(this.StockPathTextbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(641, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sheets";
            // 
            // SheetsCbo
            // 
            this.SheetsCbo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SheetsCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SheetsCbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SheetsCbo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SheetsCbo.FormattingEnabled = true;
            this.SheetsCbo.Location = new System.Drawing.Point(724, 20);
            this.SheetsCbo.Name = "SheetsCbo";
            this.SheetsCbo.Size = new System.Drawing.Size(168, 29);
            this.SheetsCbo.TabIndex = 5;
            this.SheetsCbo.SelectedIndexChanged += new System.EventHandler(this.SheetsCbo_SelectedIndexChanged);
            // 
            // AddStockButton
            // 
            this.AddStockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddStockButton.BackColor = System.Drawing.Color.White;
            this.AddStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStockButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStockButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddStockButton.Location = new System.Drawing.Point(898, 19);
            this.AddStockButton.Name = "AddStockButton";
            this.AddStockButton.Size = new System.Drawing.Size(110, 37);
            this.AddStockButton.TabIndex = 4;
            this.AddStockButton.Text = "Add Stock";
            this.AddStockButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddStockButton.UseVisualStyleBackColor = false;
            this.AddStockButton.Click += new System.EventHandler(this.AddStockButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(509, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "TryCode";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImportStockButton
            // 
            this.ImportStockButton.BackColor = System.Drawing.Color.White;
            this.ImportStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportStockButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportStockButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ImportStockButton.Location = new System.Drawing.Point(393, 17);
            this.ImportStockButton.Name = "ImportStockButton";
            this.ImportStockButton.Size = new System.Drawing.Size(110, 37);
            this.ImportStockButton.TabIndex = 4;
            this.ImportStockButton.Text = "Import";
            this.ImportStockButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImportStockButton.UseVisualStyleBackColor = false;
            this.ImportStockButton.Click += new System.EventHandler(this.ImportStockButton_Click);
            // 
            // StockPathTextbox
            // 
            this.StockPathTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockPathTextbox.Location = new System.Drawing.Point(12, 19);
            this.StockPathTextbox.Name = "StockPathTextbox";
            this.StockPathTextbox.ReadOnly = true;
            this.StockPathTextbox.Size = new System.Drawing.Size(373, 29);
            this.StockPathTextbox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 10);
            this.panel2.TabIndex = 1;
            // 
            // lblSavedItems
            // 
            this.lblSavedItems.AutoSize = true;
            this.lblSavedItems.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavedItems.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSavedItems.Location = new System.Drawing.Point(6, 60);
            this.lblSavedItems.Name = "lblSavedItems";
            this.lblSavedItems.Size = new System.Drawing.Size(33, 37);
            this.lblSavedItems.TabIndex = 6;
            this.lblSavedItems.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblAddingItems);
            this.panel3.Controls.Add(this.DgvRowCount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1022, 28);
            this.panel3.TabIndex = 3;
            // 
            // lblAddingItems
            // 
            this.lblAddingItems.AutoSize = true;
            this.lblAddingItems.BackColor = System.Drawing.Color.Transparent;
            this.lblAddingItems.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAddingItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddingItems.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAddingItems.Location = new System.Drawing.Point(902, 0);
            this.lblAddingItems.Name = "lblAddingItems";
            this.lblAddingItems.Size = new System.Drawing.Size(120, 19);
            this.lblAddingItems.TabIndex = 6;
            this.lblAddingItems.Text = "Adding Item(s)...";
            // 
            // DgvRowCount
            // 
            this.DgvRowCount.AutoSize = true;
            this.DgvRowCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.DgvRowCount.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvRowCount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DgvRowCount.Location = new System.Drawing.Point(0, 0);
            this.DgvRowCount.Name = "DgvRowCount";
            this.DgvRowCount.Size = new System.Drawing.Size(41, 13);
            this.DgvRowCount.TabIndex = 6;
            this.DgvRowCount.Text = "Sheets";
            // 
            // ImportStockGrid
            // 
            this.ImportStockGrid.AllowUserToAddRows = false;
            this.ImportStockGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.ImportStockGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImportStockGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ImportStockGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ImportStockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportStockGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportStockGrid.Location = new System.Drawing.Point(0, 0);
            this.ImportStockGrid.Name = "ImportStockGrid";
            this.ImportStockGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ImportStockGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ImportStockGrid.RowHeadersWidth = 45;
            this.ImportStockGrid.Size = new System.Drawing.Size(786, 399);
            this.ImportStockGrid.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.ExistingItemNames);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblExistingItem);
            this.panel4.Controls.Add(this.lblSavedItems);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(786, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 399);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 2);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExistingItemNames
            // 
            this.ExistingItemNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExistingItemNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExistingItemNames.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingItemNames.FormattingEnabled = true;
            this.ExistingItemNames.ItemHeight = 17;
            this.ExistingItemNames.Location = new System.Drawing.Point(5, 199);
            this.ExistingItemNames.Name = "ExistingItemNames";
            this.ExistingItemNames.Size = new System.Drawing.Size(228, 187);
            this.ExistingItemNames.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Existing Item";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item(s) Saved:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExistingItem
            // 
            this.lblExistingItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExistingItem.AutoSize = true;
            this.lblExistingItem.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingItem.ForeColor = System.Drawing.Color.Red;
            this.lblExistingItem.Location = new System.Drawing.Point(6, 152);
            this.lblExistingItem.Name = "lblExistingItem";
            this.lblExistingItem.Size = new System.Drawing.Size(33, 37);
            this.lblExistingItem.TabIndex = 6;
            this.lblExistingItem.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.ImportStockGrid);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(786, 399);
            this.panel5.TabIndex = 6;
            // 
            // ImportStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1022, 509);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 120);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Import Stock";
            this.Load += new System.EventHandler(this.ImportStockForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportStockGrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox StockPathTextbox;
        private System.Windows.Forms.Button ImportStockButton;
        private System.Windows.Forms.Button AddStockButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SheetsCbo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label DgvRowCount;
        private System.Windows.Forms.DataGridView ImportStockGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSavedItems;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExistingItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ExistingItemNames;
        private System.Windows.Forms.Label lblAddingItems;
    }
}