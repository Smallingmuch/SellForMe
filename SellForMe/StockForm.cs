using SellForMe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellForMe
{
    public partial class StockForm : Form
    {
        public byte[] byteImg;
        public StockForm()
        {
            InitializeComponent();
            LblItemCode.Text = "ITEM-"+GlobalSettings.RandomCode();
            ItemNameTextbox.Focus();
        }
        public void ClearTextboxControls()
        {
            foreach (Control txt in groupBox1.Controls.OfType<TextBox>())
            {
                txt.Text = string.Empty;
            }
        }

        public void CheckNumericDropDown()
        {
            foreach(Control Nd in groupBox1.Controls.OfType<NumericUpDown>())
            {
                if(Nd.Text == "" || Nd.Text == " ")
                {
                    Nd.Text = "0";
                    MessageBox.Show("Available and Reorder Quantity must be filled", "Sell For Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
        private void LblImportItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ImportStockForm newImport = new ImportStockForm();
            newImport.ShowDialog();


        }
        private void AddItemButton_Click_1(object sender, EventArgs e)
        {
           
            foreach (Control textbox in groupBox1.Controls.OfType<TextBox>())
            {
                if (textbox.Text == string.Empty)
                {
                    MessageBox.Show("All fields are required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }            
                StockModel stock = new StockModel
                {
                Id = LblItemCode.Text,
                Product = ItemNameTextbox.Text,
                Description = ItemDescr.Text,
                Cost = Convert.ToDecimal(CostTextbox.Text),
                Retail = Convert.ToDecimal(RetailTextbox.Text),
                WholeSale = Convert.ToDecimal(WholesaleTextbox.Text),
                Quantity = int.Parse(QuantityTextbox.Text),
                ReorderQty = int.Parse(ItemReorder.Text),
                Size = ItemSize.Text,                
                BusinessName = GlobalSettings.StoreName
                };
            if (stock.AddStock())
            {
                MessageBox.Show("Item Added", "Sell For Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                MessageBox.Show(GlobalSettings.ErrorMsg.ToString(), "Sell For Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                LblItemCode.Text = "ITEM-"+GlobalSettings.RandomCode();
        }
        public void TextChange(TextBox txt)
        {
            if (txt.Text == "" || txt.Text == " ")
            {
                txt.Text = "0.00";
                MessageBox.Show("Enter valid amount", "Sell for Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
          

            if (txt.Text.All(char.IsDigit))
            {
                txt.Text = Convert.ToDecimal(Convert.ToDecimal(txt.Text)).ToString("N2");
                
            }
            else
            {
                MessageBox.Show("Enter amount in numbers only\n\n- Alphabets and Symbols not allowed.", "Sell for Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void ChecktInputLeave(TextBox txt)
        {
            if(txt.Text == "" || !txt.Text.Trim().All(char.IsDigit))
            {
                txt.Text = "0.00";
            }
            else
            {
                txt.Text = Convert.ToDecimal(txt.Text).ToString("N2");
            }
        }
        private void CostTextbox_Leave(object sender, EventArgs e)
        {
            ChecktInputLeave(CostTextbox);
        }
        private void RetailTextbox_Leave(object sender, EventArgs e)
        {
            ChecktInputLeave(RetailTextbox);
        }
        private void WholesaleTextbox_Leave(object sender, EventArgs e)
        {
            ChecktInputLeave(WholesaleTextbox);
        }
        private void QuantityTextbox_Leave(object sender, EventArgs e)
        {
            CheckNumericDropDown();
        }
        private void ItemReorder_Leave(object sender, EventArgs e)
        {
            CheckNumericDropDown();
        }
    }
}
