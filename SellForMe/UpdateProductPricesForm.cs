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
    public partial class UpdateProductPricesForm : Form
    {
        public UpdateProductPricesForm()
        {
            InitializeComponent();
        }

        private void linkLabelAddNewStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockForm NewStock = new StockForm();
            NewStock.ShowDialog();
            
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
