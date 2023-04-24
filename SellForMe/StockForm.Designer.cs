namespace SellForMe
{
    partial class StockForm
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
            this.LblImportItems = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemReorder = new System.Windows.Forms.NumericUpDown();
            this.QuantityTextbox = new System.Windows.Forms.NumericUpDown();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.WholesaleTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RetailTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CostTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemDescr = new System.Windows.Forms.TextBox();
            this.ItemNameTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LblItemCode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemReorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.LblImportItems);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 56);
            this.panel1.TabIndex = 2;
            // 
            // LblImportItems
            // 
            this.LblImportItems.AutoSize = true;
            this.LblImportItems.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LblImportItems.LinkColor = System.Drawing.Color.White;
            this.LblImportItems.Location = new System.Drawing.Point(365, 9);
            this.LblImportItems.Name = "LblImportItems";
            this.LblImportItems.Size = new System.Drawing.Size(116, 25);
            this.LblImportItems.TabIndex = 1;
            this.LblImportItems.TabStop = true;
            this.LblImportItems.Text = "Import Items";
            this.LblImportItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblImportItems_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Stock";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ItemReorder);
            this.groupBox1.Controls.Add(this.QuantityTextbox);
            this.groupBox1.Controls.Add(this.AddItemButton);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.WholesaleTextbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ItemSize);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.RetailTextbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CostTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ItemDescr);
            this.groupBox1.Controls.Add(this.ItemNameTextbox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.LblItemCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 405);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // ItemReorder
            // 
            this.ItemReorder.Location = new System.Drawing.Point(176, 343);
            this.ItemReorder.Name = "ItemReorder";
            this.ItemReorder.Size = new System.Drawing.Size(133, 31);
            this.ItemReorder.TabIndex = 27;
            this.ItemReorder.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ItemReorder.Leave += new System.EventHandler(this.ItemReorder_Leave);
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.Location = new System.Drawing.Point(20, 343);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.Size = new System.Drawing.Size(134, 31);
            this.QuantityTextbox.TabIndex = 26;
            this.QuantityTextbox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.QuantityTextbox.Leave += new System.EventHandler(this.QuantityTextbox_Leave);
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.ForeColor = System.Drawing.Color.White;
            this.AddItemButton.Location = new System.Drawing.Point(338, 334);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(139, 40);
            this.AddItemButton.TabIndex = 28;
            this.AddItemButton.Text = "ADD ITEM";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Reorder Qty";
            // 
            // WholesaleTextbox
            // 
            this.WholesaleTextbox.Location = new System.Drawing.Point(259, 281);
            this.WholesaleTextbox.Name = "WholesaleTextbox";
            this.WholesaleTextbox.Size = new System.Drawing.Size(216, 31);
            this.WholesaleTextbox.TabIndex = 24;
            this.WholesaleTextbox.Text = "0.00";
            this.WholesaleTextbox.Leave += new System.EventHandler(this.WholesaleTextbox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Wholesale Cost";
            // 
            // ItemSize
            // 
            this.ItemSize.Location = new System.Drawing.Point(291, 220);
            this.ItemSize.Name = "ItemSize";
            this.ItemSize.Size = new System.Drawing.Size(187, 31);
            this.ItemSize.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Size";
            // 
            // RetailTextbox
            // 
            this.RetailTextbox.Location = new System.Drawing.Point(21, 281);
            this.RetailTextbox.Name = "RetailTextbox";
            this.RetailTextbox.Size = new System.Drawing.Size(213, 31);
            this.RetailTextbox.TabIndex = 13;
            this.RetailTextbox.Text = "0.00";
            this.RetailTextbox.Leave += new System.EventHandler(this.RetailTextbox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Avl. Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Retail Cost";
            // 
            // CostTextbox
            // 
            this.CostTextbox.Location = new System.Drawing.Point(20, 218);
            this.CostTextbox.Name = "CostTextbox";
            this.CostTextbox.Size = new System.Drawing.Size(248, 31);
            this.CostTextbox.TabIndex = 11;
            this.CostTextbox.Text = "0.00";
            this.CostTextbox.Leave += new System.EventHandler(this.CostTextbox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cost";
            // 
            // ItemDescr
            // 
            this.ItemDescr.Location = new System.Drawing.Point(20, 123);
            this.ItemDescr.Multiline = true;
            this.ItemDescr.Name = "ItemDescr";
            this.ItemDescr.Size = new System.Drawing.Size(455, 62);
            this.ItemDescr.TabIndex = 10;
            // 
            // ItemNameTextbox
            // 
            this.ItemNameTextbox.Location = new System.Drawing.Point(20, 64);
            this.ItemNameTextbox.Name = "ItemNameTextbox";
            this.ItemNameTextbox.Size = new System.Drawing.Size(455, 31);
            this.ItemNameTextbox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Description";
            // 
            // LblItemCode
            // 
            this.LblItemCode.AutoSize = true;
            this.LblItemCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LblItemCode.Location = new System.Drawing.Point(342, 20);
            this.LblItemCode.Name = "LblItemCode";
            this.LblItemCode.Size = new System.Drawing.Size(48, 20);
            this.LblItemCode.TabIndex = 14;
            this.LblItemCode.Text = "ITEM-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(255, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Item Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Item Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(493, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "StockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemReorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LblImportItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ItemReorder;
        private System.Windows.Forms.NumericUpDown QuantityTextbox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox WholesaleTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RetailTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CostTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemDescr;
        private System.Windows.Forms.TextBox ItemNameTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblItemCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}