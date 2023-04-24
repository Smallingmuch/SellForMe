namespace SellForMe
{
    partial class NewPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PmtMethodGroup = new System.Windows.Forms.GroupBox();
            this.cboPmtMethod = new System.Windows.Forms.ComboBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalInvoice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SavePurchaseButton = new System.Windows.Forms.Button();
            this.txtWaybillNo = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProductSearch = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductsGrid = new System.Windows.Forms.DataGridView();
            this.ItemNames = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discounted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.PmtMethodGroup.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.PmtMethodGroup);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.cboSupplier);
            this.panel1.Controls.Add(this.dtpPurchaseDate);
            this.panel1.Controls.Add(this.lblTotalInvoice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.SavePurchaseButton);
            this.panel1.Controls.Add(this.txtWaybillNo);
            this.panel1.Controls.Add(this.txtRemark);
            this.panel1.Controls.Add(this.txtBatchNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 239);
            this.panel1.TabIndex = 0;
            // 
            // PmtMethodGroup
            // 
            this.PmtMethodGroup.Controls.Add(this.cboPmtMethod);
            this.PmtMethodGroup.Controls.Add(this.lblAmountPaid);
            this.PmtMethodGroup.Controls.Add(this.label4);
            this.PmtMethodGroup.Controls.Add(this.txtAmountPaid);
            this.PmtMethodGroup.Location = new System.Drawing.Point(498, 7);
            this.PmtMethodGroup.Name = "PmtMethodGroup";
            this.PmtMethodGroup.Size = new System.Drawing.Size(207, 160);
            this.PmtMethodGroup.TabIndex = 12;
            this.PmtMethodGroup.TabStop = false;
            // 
            // cboPmtMethod
            // 
            this.cboPmtMethod.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboPmtMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPmtMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPmtMethod.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cboPmtMethod.FormattingEnabled = true;
            this.cboPmtMethod.Items.AddRange(new object[] {
            "Cash",
            "Transfer",
            "POS",
            "Credit Facility"});
            this.cboPmtMethod.Location = new System.Drawing.Point(8, 50);
            this.cboPmtMethod.Name = "cboPmtMethod";
            this.cboPmtMethod.Size = new System.Drawing.Size(180, 33);
            this.cboPmtMethod.TabIndex = 0;
            this.cboPmtMethod.TextChanged += new System.EventHandler(this.cboPmtMethod_TextChanged);
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.ForeColor = System.Drawing.Color.White;
            this.lblAmountPaid.Location = new System.Drawing.Point(6, 92);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(115, 25);
            this.lblAmountPaid.TabIndex = 8;
            this.lblAmountPaid.Text = "Amount Paid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pmt. Method";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(8, 120);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(180, 31);
            this.txtAmountPaid.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(107, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 23);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Auto";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cboSupplier
            // 
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(12, 113);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(480, 33);
            this.cboSupplier.TabIndex = 3;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(344, 50);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(148, 31);
            this.dtpPurchaseDate.TabIndex = 2;
            // 
            // lblTotalInvoice
            // 
            this.lblTotalInvoice.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTotalInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalInvoice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvoice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalInvoice.Location = new System.Drawing.Point(344, 190);
            this.lblTotalInvoice.Name = "lblTotalInvoice";
            this.lblTotalInvoice.Size = new System.Drawing.Size(361, 39);
            this.lblTotalInvoice.TabIndex = 8;
            this.lblTotalInvoice.Text = "Invoice Total";
            this.lblTotalInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(353, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Invoice Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Remarks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(339, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Purchase Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wabill No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Batch No.";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(723, 141);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(101, 40);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(723, 91);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(101, 40);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            // 
            // SavePurchaseButton
            // 
            this.SavePurchaseButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SavePurchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePurchaseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePurchaseButton.ForeColor = System.Drawing.Color.White;
            this.SavePurchaseButton.Location = new System.Drawing.Point(723, 39);
            this.SavePurchaseButton.Name = "SavePurchaseButton";
            this.SavePurchaseButton.Size = new System.Drawing.Size(101, 40);
            this.SavePurchaseButton.TabIndex = 5;
            this.SavePurchaseButton.Text = "Save";
            this.SavePurchaseButton.UseVisualStyleBackColor = false;
            this.SavePurchaseButton.Click += new System.EventHandler(this.SavePurchaseButton_Click);
            // 
            // txtWaybillNo
            // 
            this.txtWaybillNo.Location = new System.Drawing.Point(178, 50);
            this.txtWaybillNo.Name = "txtWaybillNo";
            this.txtWaybillNo.Size = new System.Drawing.Size(160, 31);
            this.txtWaybillNo.TabIndex = 1;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(12, 177);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(326, 56);
            this.txtRemark.TabIndex = 4;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(12, 50);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(160, 31);
            this.txtBatchNo.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblProductSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 239);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(836, 28);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblProductSearch
            // 
            this.lblProductSearch.AutoSize = true;
            this.lblProductSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSearch.Location = new System.Drawing.Point(3, 0);
            this.lblProductSearch.Name = "lblProductSearch";
            this.lblProductSearch.Size = new System.Drawing.Size(106, 20);
            this.lblProductSearch.TabIndex = 0;
            this.lblProductSearch.TabStop = true;
            this.lblProductSearch.Text = "Product search";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProductsGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 256);
            this.panel2.TabIndex = 2;
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ProductsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNames,
            this.Qty,
            this.UnitCost,
            this.TotalCost,
            this.Discounted});
            this.ProductsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsGrid.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.ProductsGrid.Location = new System.Drawing.Point(0, 0);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductsGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductsGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.AliceBlue;
            this.ProductsGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductsGrid.RowTemplate.Height = 35;
            this.ProductsGrid.Size = new System.Drawing.Size(836, 256);
            this.ProductsGrid.TabIndex = 0;
            this.ProductsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGrid_CellEndEdit);
            this.ProductsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGrid_CellValueChanged);
            // 
            // ItemNames
            // 
            this.ItemNames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemNames.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ItemNames.DisplayStyleForCurrentCellOnly = true;
            this.ItemNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemNames.HeaderText = "Item Names";
            this.ItemNames.MinimumWidth = 6;
            this.ItemNames.Name = "ItemNames";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Qty.Width = 110;
            // 
            // UnitCost
            // 
            this.UnitCost.HeaderText = "Unit Cost";
            this.UnitCost.MinimumWidth = 6;
            this.UnitCost.Name = "UnitCost";
            this.UnitCost.Width = 120;
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.MinimumWidth = 6;
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Width = 120;
            // 
            // Discounted
            // 
            this.Discounted.HeaderText = "Discounted";
            this.Discounted.MinimumWidth = 6;
            this.Discounted.Name = "Discounted";
            this.Discounted.Width = 110;
            // 
            // NewPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Purchases";
            this.Activated += new System.EventHandler(this.NewPurchase_Activated);
            this.Load += new System.EventHandler(this.NewPurchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PmtMethodGroup.ResumeLayout(false);
            this.PmtMethodGroup.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SavePurchaseButton;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalInvoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox txtWaybillNo;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.LinkLabel lblProductSearch;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cboPmtMethod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox PmtMethodGroup;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discounted;
    }
}