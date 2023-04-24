namespace SellForMe
{
    partial class SalesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RdoWholesale = new System.Windows.Forms.RadioButton();
            this.RdoRetail = new System.Windows.Forms.RadioButton();
            this.SalesDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.ItemNames = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InvoiceID = new System.Windows.Forms.TextBox();
            this.LoggedInCashierAssociate = new System.Windows.Forms.TextBox();
            this.LoggedInCashier = new System.Windows.Forms.TextBox();
            this.PromoCode = new System.Windows.Forms.TextBox();
            this.MakeSalesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SalesItemGridView = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelSalesButton = new System.Windows.Forms.Button();
            this.TotalItemsLabel = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BalanceOrChange = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DiscountTotalLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PaymentMethod = new System.Windows.Forms.ComboBox();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.AmountTendered = new System.Windows.Forms.TextBox();
            this.DiscountChk = new System.Windows.Forms.CheckBox();
            this.DiscountTotalText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesItemGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.RdoWholesale);
            this.panel1.Controls.Add(this.RdoRetail);
            this.panel1.Controls.Add(this.SalesDatetimePicker);
            this.panel1.Controls.Add(this.ItemNames);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.InvoiceID);
            this.panel1.Controls.Add(this.LoggedInCashierAssociate);
            this.panel1.Controls.Add(this.LoggedInCashier);
            this.panel1.Controls.Add(this.PromoCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 84);
            this.panel1.TabIndex = 2;
            // 
            // RdoWholesale
            // 
            this.RdoWholesale.AutoSize = true;
            this.RdoWholesale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoWholesale.ForeColor = System.Drawing.Color.White;
            this.RdoWholesale.Location = new System.Drawing.Point(126, 12);
            this.RdoWholesale.Name = "RdoWholesale";
            this.RdoWholesale.Size = new System.Drawing.Size(99, 24);
            this.RdoWholesale.TabIndex = 6;
            this.RdoWholesale.Text = "Wholesale";
            this.RdoWholesale.UseVisualStyleBackColor = true;
            // 
            // RdoRetail
            // 
            this.RdoRetail.AutoSize = true;
            this.RdoRetail.Checked = true;
            this.RdoRetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoRetail.ForeColor = System.Drawing.Color.White;
            this.RdoRetail.Location = new System.Drawing.Point(24, 12);
            this.RdoRetail.Name = "RdoRetail";
            this.RdoRetail.Size = new System.Drawing.Size(67, 24);
            this.RdoRetail.TabIndex = 6;
            this.RdoRetail.TabStop = true;
            this.RdoRetail.Text = "Retail";
            this.RdoRetail.UseVisualStyleBackColor = true;
            // 
            // SalesDatetimePicker
            // 
            this.SalesDatetimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesDatetimePicker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDatetimePicker.Location = new System.Drawing.Point(847, 4);
            this.SalesDatetimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.SalesDatetimePicker.Name = "SalesDatetimePicker";
            this.SalesDatetimePicker.Size = new System.Drawing.Size(188, 27);
            this.SalesDatetimePicker.TabIndex = 5;
            // 
            // ItemNames
            // 
            this.ItemNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemNames.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNames.FormattingEnabled = true;
            this.ItemNames.Location = new System.Drawing.Point(115, 47);
            this.ItemNames.Margin = new System.Windows.Forms.Padding(2);
            this.ItemNames.Name = "ItemNames";
            this.ItemNames.Size = new System.Drawing.Size(402, 28);
            this.ItemNames.TabIndex = 4;
            this.ItemNames.SelectedIndexChanged += new System.EventHandler(this.ItemNames_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(796, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(768, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Associate";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(783, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cashier";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(275, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Invoice ID";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(577, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Promo Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Item (s)";
            // 
            // InvoiceID
            // 
            this.InvoiceID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceID.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceID.Location = new System.Drawing.Point(358, 9);
            this.InvoiceID.Margin = new System.Windows.Forms.Padding(2);
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.ReadOnly = true;
            this.InvoiceID.Size = new System.Drawing.Size(204, 24);
            this.InvoiceID.TabIndex = 0;
            // 
            // LoggedInCashierAssociate
            // 
            this.LoggedInCashierAssociate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoggedInCashierAssociate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInCashierAssociate.Location = new System.Drawing.Point(847, 57);
            this.LoggedInCashierAssociate.Margin = new System.Windows.Forms.Padding(2);
            this.LoggedInCashierAssociate.Name = "LoggedInCashierAssociate";
            this.LoggedInCashierAssociate.ReadOnly = true;
            this.LoggedInCashierAssociate.Size = new System.Drawing.Size(188, 24);
            this.LoggedInCashierAssociate.TabIndex = 0;
            // 
            // LoggedInCashier
            // 
            this.LoggedInCashier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoggedInCashier.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInCashier.Location = new System.Drawing.Point(847, 32);
            this.LoggedInCashier.Margin = new System.Windows.Forms.Padding(2);
            this.LoggedInCashier.Name = "LoggedInCashier";
            this.LoggedInCashier.ReadOnly = true;
            this.LoggedInCashier.Size = new System.Drawing.Size(188, 24);
            this.LoggedInCashier.TabIndex = 0;
            // 
            // PromoCode
            // 
            this.PromoCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PromoCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoCode.Location = new System.Drawing.Point(675, 6);
            this.PromoCode.Margin = new System.Windows.Forms.Padding(2);
            this.PromoCode.Name = "PromoCode";
            this.PromoCode.Size = new System.Drawing.Size(118, 27);
            this.PromoCode.TabIndex = 0;
            // 
            // MakeSalesButton
            // 
            this.MakeSalesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MakeSalesButton.BackColor = System.Drawing.Color.White;
            this.MakeSalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeSalesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeSalesButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MakeSalesButton.Location = new System.Drawing.Point(675, 455);
            this.MakeSalesButton.Margin = new System.Windows.Forms.Padding(2);
            this.MakeSalesButton.Name = "MakeSalesButton";
            this.MakeSalesButton.Size = new System.Drawing.Size(220, 49);
            this.MakeSalesButton.TabIndex = 3;
            this.MakeSalesButton.Text = "Make Sales";
            this.MakeSalesButton.UseVisualStyleBackColor = false;
            this.MakeSalesButton.Click += new System.EventHandler(this.MakeSalesButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.SalesItemGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 250);
            this.panel2.TabIndex = 4;
            // 
            // SalesItemGridView
            // 
            this.SalesItemGridView.AllowUserToAddRows = false;
            this.SalesItemGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SalesItemGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalesItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesItemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.ItemSize,
            this.Qty,
            this.UnitPrice,
            this.TotalAmount,
            this.Discount,
            this.ItemDescription});
            this.SalesItemGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesItemGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.SalesItemGridView.Location = new System.Drawing.Point(0, 0);
            this.SalesItemGridView.Margin = new System.Windows.Forms.Padding(2);
            this.SalesItemGridView.Name = "SalesItemGridView";
            this.SalesItemGridView.RowHeadersWidth = 45;
            this.SalesItemGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalesItemGridView.Size = new System.Drawing.Size(1044, 250);
            this.SalesItemGridView.TabIndex = 0;
            this.SalesItemGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditDataGridViewCell);
            this.SalesItemGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.SalesItemGridView_DataError);
            this.SalesItemGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.RowDeleted);
            // 
            // ItemCode
            // 
            this.ItemCode.Frozen = true;
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemCode.Width = 120;
            // 
            // ItemName
            // 
            this.ItemName.Frozen = true;
            this.ItemName.HeaderText = "Item Names";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ItemName.Width = 300;
            // 
            // ItemSize
            // 
            this.ItemSize.HeaderText = "Size";
            this.ItemSize.MinimumWidth = 6;
            this.ItemSize.Name = "ItemSize";
            this.ItemSize.ReadOnly = true;
            this.ItemSize.Width = 50;
            // 
            // Qty
            // 
            dataGridViewCellStyle1.NullValue = "1";
            this.Qty.DefaultCellStyle = dataGridViewCellStyle1;
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.ToolTipText = "Enter only Numbers please";
            this.Qty.Width = 50;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 110;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 200;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Width = 110;
            // 
            // ItemDescription
            // 
            this.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemDescription.HeaderText = "Description";
            this.ItemDescription.MinimumWidth = 6;
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // CancelSalesButton
            // 
            this.CancelSalesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSalesButton.BackColor = System.Drawing.Color.White;
            this.CancelSalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSalesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSalesButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CancelSalesButton.Location = new System.Drawing.Point(906, 463);
            this.CancelSalesButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelSalesButton.Name = "CancelSalesButton";
            this.CancelSalesButton.Size = new System.Drawing.Size(129, 41);
            this.CancelSalesButton.TabIndex = 3;
            this.CancelSalesButton.Text = "Cancel";
            this.CancelSalesButton.UseVisualStyleBackColor = false;
            this.CancelSalesButton.Click += new System.EventHandler(this.CancelSalesButton_Click);
            // 
            // TotalItemsLabel
            // 
            this.TotalItemsLabel.AutoSize = true;
            this.TotalItemsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TotalItemsLabel.Location = new System.Drawing.Point(5, 348);
            this.TotalItemsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalItemsLabel.Name = "TotalItemsLabel";
            this.TotalItemsLabel.Size = new System.Drawing.Size(73, 20);
            this.TotalItemsLabel.TabIndex = 5;
            this.TotalItemsLabel.Text = "0 item(s)";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(933, 351);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(102, 32);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove All";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalLabel.Location = new System.Drawing.Point(79, 19);
            this.SubTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(40, 20);
            this.SubTotalLabel.TabIndex = 6;
            this.SubTotalLabel.Text = "0.00";
            this.SubTotalLabel.TextChanged += new System.EventHandler(this.SubTotalLabel_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sub Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(9, 377);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Amount Tendered";
            // 
            // BalanceOrChange
            // 
            this.BalanceOrChange.AutoSize = true;
            this.BalanceOrChange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceOrChange.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BalanceOrChange.Location = new System.Drawing.Point(155, 377);
            this.BalanceOrChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BalanceOrChange.Name = "BalanceOrChange";
            this.BalanceOrChange.Size = new System.Drawing.Size(68, 20);
            this.BalanceOrChange.TabIndex = 6;
            this.BalanceOrChange.Text = "Change?";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DiscountTotalLabel);
            this.groupBox1.Controls.Add(this.SubTotalLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(233, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 56);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Discount Total:";
            // 
            // DiscountTotalLabel
            // 
            this.DiscountTotalLabel.AutoSize = true;
            this.DiscountTotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTotalLabel.Location = new System.Drawing.Point(112, 56);
            this.DiscountTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiscountTotalLabel.Name = "DiscountTotalLabel";
            this.DiscountTotalLabel.Size = new System.Drawing.Size(40, 20);
            this.DiscountTotalLabel.TabIndex = 6;
            this.DiscountTotalLabel.Text = "0.00";
            this.DiscountTotalLabel.Click += new System.EventHandler(this.DiscountTotalLabel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.TotalLabel);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(666, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 59);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(15, 19);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(64, 32);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "0.00";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(666, 365);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Invoice Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(8, 439);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Payment Method";
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PaymentMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.FormattingEnabled = true;
            this.PaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Tranfer"});
            this.PaymentMethod.Location = new System.Drawing.Point(11, 461);
            this.PaymentMethod.Margin = new System.Windows.Forms.Padding(2);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(141, 28);
            this.PaymentMethod.TabIndex = 4;
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLabel.Location = new System.Drawing.Point(156, 402);
            this.ChangeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(37, 19);
            this.ChangeLabel.TabIndex = 6;
            this.ChangeLabel.Text = "0.00";
            // 
            // AmountTendered
            // 
            this.AmountTendered.Location = new System.Drawing.Point(13, 402);
            this.AmountTendered.Name = "AmountTendered";
            this.AmountTendered.Size = new System.Drawing.Size(138, 27);
            this.AmountTendered.TabIndex = 8;
            this.AmountTendered.Text = "0.00";
            this.AmountTendered.TextChanged += new System.EventHandler(this.AmountTendered_TextChanged);
            this.AmountTendered.Leave += new System.EventHandler(this.AmountTendered_Leave);
            // 
            // DiscountChk
            // 
            this.DiscountChk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountChk.AutoSize = true;
            this.DiscountChk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountChk.Location = new System.Drawing.Point(233, 457);
            this.DiscountChk.Name = "DiscountChk";
            this.DiscountChk.Size = new System.Drawing.Size(175, 24);
            this.DiscountChk.TabIndex = 9;
            this.DiscountChk.Text = "Discount from Total?";
            this.DiscountChk.UseVisualStyleBackColor = true;
            this.DiscountChk.CheckedChanged += new System.EventHandler(this.DiscountChk_CheckedChanged);
            // 
            // DiscountTotalText
            // 
            this.DiscountTotalText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountTotalText.Location = new System.Drawing.Point(414, 455);
            this.DiscountTotalText.Name = "DiscountTotalText";
            this.DiscountTotalText.ReadOnly = true;
            this.DiscountTotalText.Size = new System.Drawing.Size(246, 27);
            this.DiscountTotalText.TabIndex = 8;
            this.DiscountTotalText.Text = "0.00";
            this.DiscountTotalText.TextChanged += new System.EventHandler(this.DiscountTotalText_TextChanged);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1044, 534);
            this.Controls.Add(this.DiscountChk);
            this.Controls.Add(this.DiscountTotalText);
            this.Controls.Add(this.AmountTendered);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BalanceOrChange);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalItemsLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.CancelSalesButton);
            this.Controls.Add(this.MakeSalesButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 110);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "New Sales Receipt";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesItemGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker SalesDatetimePicker;
        private System.Windows.Forms.ComboBox ItemNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoggedInCashierAssociate;
        private System.Windows.Forms.TextBox LoggedInCashier;
        private System.Windows.Forms.TextBox PromoCode;
        private System.Windows.Forms.Button MakeSalesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView SalesItemGridView;
        private System.Windows.Forms.Button CancelSalesButton;
        private System.Windows.Forms.Label TotalItemsLabel;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label BalanceOrChange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DiscountTotalLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox PaymentMethod;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.TextBox AmountTendered;
        private System.Windows.Forms.CheckBox DiscountChk;
        private System.Windows.Forms.TextBox DiscountTotalText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.RadioButton RdoWholesale;
        private System.Windows.Forms.RadioButton RdoRetail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox InvoiceID;
    }
}