namespace SellForMe
{
    partial class ProductListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNewItem = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblGridItem = new System.Windows.Forms.Label();
            this.StocksDgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhosaleCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StocksDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblNewItem);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ItemName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 119);
            this.panel1.TabIndex = 0;
            // 
            // lblNewItem
            // 
            this.lblNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewItem.AutoSize = true;
            this.lblNewItem.ForeColor = System.Drawing.Color.White;
            this.lblNewItem.LinkColor = System.Drawing.Color.White;
            this.lblNewItem.Location = new System.Drawing.Point(923, 9);
            this.lblNewItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewItem.Name = "lblNewItem";
            this.lblNewItem.Size = new System.Drawing.Size(77, 21);
            this.lblNewItem.TabIndex = 5;
            this.lblNewItem.TabStop = true;
            this.lblNewItem.Text = "New Item";
            this.lblNewItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNewItem_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(786, 9);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 21);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Refresh Data";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by";
            // 
            // ItemName
            // 
            this.ItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(132, 67);
            this.ItemName.Margin = new System.Windows.Forms.Padding(2);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(536, 25);
            this.ItemName.TabIndex = 0;
            this.ItemName.TextChanged += new System.EventHandler(this.ItemName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.LblGridItem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 487);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1022, 22);
            this.panel3.TabIndex = 2;
            // 
            // LblGridItem
            // 
            this.LblGridItem.AutoSize = true;
            this.LblGridItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGridItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblGridItem.Location = new System.Drawing.Point(6, 1);
            this.LblGridItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGridItem.Name = "LblGridItem";
            this.LblGridItem.Size = new System.Drawing.Size(110, 19);
            this.LblGridItem.TabIndex = 1;
            this.LblGridItem.Text = "0 Item(s) Listed";
            // 
            // StocksDgv
            // 
            this.StocksDgv.AllowUserToAddRows = false;
            this.StocksDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.StocksDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StocksDgv.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StocksDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StocksDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StocksDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StocksDgv.ColumnHeadersHeight = 25;
            this.StocksDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StocksDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Product,
            this.Description,
            this.RetailCost,
            this.WhosaleCost,
            this.Qty,
            this.ReorderQty,
            this.ItemSize});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StocksDgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.StocksDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StocksDgv.EnableHeadersVisualStyles = false;
            this.StocksDgv.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StocksDgv.Location = new System.Drawing.Point(0, 119);
            this.StocksDgv.Margin = new System.Windows.Forms.Padding(2);
            this.StocksDgv.MultiSelect = false;
            this.StocksDgv.Name = "StocksDgv";
            this.StocksDgv.ReadOnly = true;
            this.StocksDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StocksDgv.RowHeadersVisible = false;
            this.StocksDgv.RowHeadersWidth = 40;
            this.StocksDgv.Size = new System.Drawing.Size(1022, 368);
            this.StocksDgv.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 110;
            // 
            // Product
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Product.DefaultCellStyle = dataGridViewCellStyle3;
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 110;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 300;
            // 
            // RetailCost
            // 
            this.RetailCost.HeaderText = "Retail Cost";
            this.RetailCost.MinimumWidth = 6;
            this.RetailCost.Name = "RetailCost";
            this.RetailCost.ReadOnly = true;
            this.RetailCost.Width = 110;
            // 
            // WhosaleCost
            // 
            this.WhosaleCost.HeaderText = "Wholesale Cost";
            this.WhosaleCost.MinimumWidth = 6;
            this.WhosaleCost.Name = "WhosaleCost";
            this.WhosaleCost.ReadOnly = true;
            this.WhosaleCost.Width = 150;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 80;
            // 
            // ReorderQty
            // 
            this.ReorderQty.HeaderText = "Reorder Qty";
            this.ReorderQty.MinimumWidth = 6;
            this.ReorderQty.Name = "ReorderQty";
            this.ReorderQty.ReadOnly = true;
            this.ReorderQty.Width = 110;
            // 
            // ItemSize
            // 
            this.ItemSize.HeaderText = "Size";
            this.ItemSize.MinimumWidth = 6;
            this.ItemSize.Name = "ItemSize";
            this.ItemSize.ReadOnly = true;
            this.ItemSize.Width = 80;
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 509);
            this.Controls.Add(this.StocksDgv);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 120);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ProductListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Item List";
            this.Activated += new System.EventHandler(this.ProductListForm_Activated);
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StocksDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblGridItem;
        private System.Windows.Forms.DataGridView StocksDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetailCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhosaleCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSize;
        private System.Windows.Forms.LinkLabel lblNewItem;
    }
}