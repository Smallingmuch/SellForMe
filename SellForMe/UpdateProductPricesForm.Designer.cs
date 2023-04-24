namespace SellForMe
{
    partial class UpdateProductPricesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelAddNewStock = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.ImportStockGrid = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WholeSaleCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportStockGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.linkLabelAddNewStock);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.SaveChangesButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ItemName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 111);
            this.panel1.TabIndex = 1;
            // 
            // linkLabelAddNewStock
            // 
            this.linkLabelAddNewStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelAddNewStock.AutoSize = true;
            this.linkLabelAddNewStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabelAddNewStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabelAddNewStock.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabelAddNewStock.Location = new System.Drawing.Point(835, 9);
            this.linkLabelAddNewStock.Name = "linkLabelAddNewStock";
            this.linkLabelAddNewStock.Size = new System.Drawing.Size(126, 21);
            this.linkLabelAddNewStock.TabIndex = 4;
            this.linkLabelAddNewStock.TabStop = true;
            this.linkLabelAddNewStock.Text = "Add New Stock";
            this.linkLabelAddNewStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelAddNewStock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddNewStock_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.Location = new System.Drawing.Point(715, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 21);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Refresh Grid";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChangesButton.BackColor = System.Drawing.Color.White;
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChangesButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SaveChangesButton.Location = new System.Drawing.Point(863, 60);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(139, 40);
            this.SaveChangesButton.TabIndex = 3;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by";
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(33, 60);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(327, 29);
            this.ItemName.TabIndex = 0;
            // 
            // ImportStockGrid
            // 
            this.ImportStockGrid.AllowUserToAddRows = false;
            this.ImportStockGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.ImportStockGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImportStockGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ImportStockGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ImportStockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportStockGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Cost,
            this.RetailCost,
            this.WholeSaleCost,
            this.Quantity,
            this.Description,
            this.DateStamp});
            this.ImportStockGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportStockGrid.Location = new System.Drawing.Point(0, 111);
            this.ImportStockGrid.Name = "ImportStockGrid";
            this.ImportStockGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ImportStockGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ImportStockGrid.RowHeadersWidth = 45;
            this.ImportStockGrid.Size = new System.Drawing.Size(1014, 399);
            this.ImportStockGrid.TabIndex = 3;
            // 
            // Product
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Product.DefaultCellStyle = dataGridViewCellStyle2;
            this.Product.DividerWidth = 1;
            this.Product.Frozen = true;
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.Width = 150;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 110;
            // 
            // RetailCost
            // 
            this.RetailCost.HeaderText = "Retail Cost";
            this.RetailCost.MinimumWidth = 6;
            this.RetailCost.Name = "RetailCost";
            this.RetailCost.Width = 120;
            // 
            // WholeSaleCost
            // 
            this.WholeSaleCost.HeaderText = "WholeSale Cost";
            this.WholeSaleCost.MinimumWidth = 6;
            this.WholeSaleCost.Name = "WholeSaleCost";
            this.WholeSaleCost.Width = 170;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 110;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 550;
            // 
            // DateStamp
            // 
            this.DateStamp.HeaderText = "DateStamp";
            this.DateStamp.MinimumWidth = 6;
            this.DateStamp.Name = "DateStamp";
            this.DateStamp.ReadOnly = true;
            this.DateStamp.Width = 110;
            // 
            // UpdateProductPricesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 510);
            this.Controls.Add(this.ImportStockGrid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateProductPricesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Item Prices";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportStockGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabelAddNewStock;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.DataGridView ImportStockGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetailCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn WholeSaleCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStamp;
    }
}