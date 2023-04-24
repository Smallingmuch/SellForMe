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
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            
            StocksDgv.RowTemplate.Height = 32;

            StockModel stocks = new StockModel();
            foreach (StockModel item in stocks.GetAllStocks(GlobalSettings.StoreName).ToList())
            {
                StocksDgv.Rows.Add(item.Id, item.Product, item.Description, item.Retail.ToString("N2"), item.WholeSale.ToString("N2"), item.Quantity, item.ReorderQty, item.Size);
            }
            LblGridItem.Text = StocksDgv.Rows.Count.ToString() + " item(s)";
        }

        private void ProductListForm_Activated(object sender, EventArgs e)
        {
            GlobalSettings.ColorGrid(StocksDgv);
        }

        private void ItemName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNewItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockForm newStock = new StockForm();
            newStock.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StocksDgv.Rows.Clear();
            StockModel stocks = new StockModel();
            foreach (StockModel item in stocks.GetAllStocks(GlobalSettings.StoreName).ToList())
            {
                StocksDgv.Rows.Add(item.Id, item.Product, item.Description, item.Size, item.Retail.ToString("N2"), item.WholeSale.ToString("N2"), item.Quantity, item.ReorderQty, item.Size);
            }
            LblGridItem.Text = StocksDgv.Rows.Count.ToString() + " item(s)";

            GlobalSettings.ColorGrid(StocksDgv);
        }
    }
}
