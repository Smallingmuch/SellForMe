
namespace SellForMe
{
    partial class PurchaseItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMDI = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WayBillTxt = new System.Windows.Forms.TextBox();
            this.BatchNoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PaymentMethod = new System.Windows.Forms.ComboBox();
            this.ReceivedFromCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearItems = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ReceivedByTxt = new System.Windows.Forms.TextBox();
            this.PurchaseGrid = new System.Windows.Forms.DataGridView();
            this.StockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMDI.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMDI
            // 
            this.pnlMDI.Controls.Add(this.panel4);
            this.pnlMDI.Controls.Add(this.panel3);
            this.pnlMDI.Controls.Add(this.panel2);
            this.pnlMDI.Controls.Add(this.panel1);
            this.pnlMDI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMDI.Location = new System.Drawing.Point(0, 0);
            this.pnlMDI.Name = "pnlMDI";
            this.pnlMDI.Size = new System.Drawing.Size(835, 560);
            this.pnlMDI.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PurchaseGrid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(835, 339);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ReceivedDate);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.WayBillTxt);
            this.panel3.Controls.Add(this.BatchNoTxt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 55);
            this.panel3.TabIndex = 2;
            // 
            // ReceivedDate
            // 
            this.ReceivedDate.Location = new System.Drawing.Point(638, 6);
            this.ReceivedDate.Name = "ReceivedDate";
            this.ReceivedDate.Size = new System.Drawing.Size(192, 31);
            this.ReceivedDate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Waybill Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Batch Number";
            // 
            // WayBillTxt
            // 
            this.WayBillTxt.Location = new System.Drawing.Point(143, 8);
            this.WayBillTxt.Name = "WayBillTxt";
            this.WayBillTxt.Size = new System.Drawing.Size(133, 31);
            this.WayBillTxt.TabIndex = 0;
            // 
            // BatchNoTxt
            // 
            this.BatchNoTxt.Location = new System.Drawing.Point(389, 8);
            this.BatchNoTxt.Name = "BatchNoTxt";
            this.BatchNoTxt.Size = new System.Drawing.Size(139, 31);
            this.BatchNoTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Received Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 60);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 41);
            this.label5.TabIndex = 31;
            this.label5.Text = "New Purchase";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PaymentMethod);
            this.panel1.Controls.Add(this.ReceivedFromCombo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ClearItems);
            this.panel1.Controls.Add(this.AddItemButton);
            this.panel1.Controls.Add(this.ReceivedByTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 106);
            this.panel1.TabIndex = 0;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.FormattingEnabled = true;
            this.PaymentMethod.Location = new System.Drawing.Point(152, 60);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(263, 33);
            this.PaymentMethod.TabIndex = 2;
            // 
            // ReceivedFromCombo
            // 
            this.ReceivedFromCombo.FormattingEnabled = true;
            this.ReceivedFromCombo.Location = new System.Drawing.Point(136, 21);
            this.ReceivedFromCombo.Name = "ReceivedFromCombo";
            this.ReceivedFromCombo.Size = new System.Drawing.Size(279, 33);
            this.ReceivedFromCombo.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Payment Method";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Recieved By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Recieved From";
            // 
            // ClearItems
            // 
            this.ClearItems.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClearItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearItems.ForeColor = System.Drawing.Color.White;
            this.ClearItems.Location = new System.Drawing.Point(726, 60);
            this.ClearItems.Name = "ClearItems";
            this.ClearItems.Size = new System.Drawing.Size(104, 40);
            this.ClearItems.TabIndex = 4;
            this.ClearItems.Text = "CLEAR";
            this.ClearItems.UseVisualStyleBackColor = false;
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.ForeColor = System.Drawing.Color.White;
            this.AddItemButton.Location = new System.Drawing.Point(459, 60);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(221, 40);
            this.AddItemButton.TabIndex = 3;
            this.AddItemButton.Text = "ADD ITEM(S)";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ReceivedByTxt
            // 
            this.ReceivedByTxt.Location = new System.Drawing.Point(516, 21);
            this.ReceivedByTxt.Name = "ReceivedByTxt";
            this.ReceivedByTxt.Size = new System.Drawing.Size(314, 31);
            this.ReceivedByTxt.TabIndex = 1;
            // 
            // PurchaseGrid
            // 
            this.PurchaseGrid.AllowUserToDeleteRows = false;
            this.PurchaseGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.PurchaseGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.PurchaseGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurchaseGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PurchaseGrid.ColumnHeadersHeight = 35;
            this.PurchaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PurchaseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockCode,
            this.StockName,
            this.Quantity,
            this.Cost,
            this.AmountTotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchaseGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.PurchaseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PurchaseGrid.Location = new System.Drawing.Point(0, 0);
            this.PurchaseGrid.Name = "PurchaseGrid";
            this.PurchaseGrid.RowHeadersWidth = 45;
            this.PurchaseGrid.RowTemplate.Height = 35;
            this.PurchaseGrid.Size = new System.Drawing.Size(835, 339);
            this.PurchaseGrid.TabIndex = 10;
            // 
            // StockCode
            // 
            this.StockCode.Frozen = true;
            this.StockCode.HeaderText = "Stock Code";
            this.StockCode.MinimumWidth = 6;
            this.StockCode.Name = "StockCode";
            this.StockCode.ReadOnly = true;
            this.StockCode.Width = 150;
            // 
            // StockName
            // 
            this.StockName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            this.StockName.DefaultCellStyle = dataGridViewCellStyle5;
            this.StockName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.StockName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockName.HeaderText = "Stock Name";
            this.StockName.MinimumWidth = 6;
            this.StockName.Name = "StockName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 80;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Rate";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 120;
            // 
            // AmountTotal
            // 
            this.AmountTotal.HeaderText = "Total Amount";
            this.AmountTotal.MinimumWidth = 6;
            this.AmountTotal.Name = "AmountTotal";
            this.AmountTotal.ReadOnly = true;
            this.AmountTotal.Width = 200;
            // 
            // PurchaseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 560);
            this.Controls.Add(this.pnlMDI);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PurchaseItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseItem";
            this.pnlMDI.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMDI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker ReceivedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WayBillTxt;
        private System.Windows.Forms.TextBox BatchNoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PaymentMethod;
        private System.Windows.Forms.ComboBox ReceivedFromCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearItems;
        private System.Windows.Forms.TextBox ReceivedByTxt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView PurchaseGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn StockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountTotal;
    }
}