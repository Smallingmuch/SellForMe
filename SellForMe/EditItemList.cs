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
    public partial class EditItemList : Form
    {
        public EditItemList()
        {
            InitializeComponent();
        }

        private void EditItemList_Load(object sender, EventArgs e)
        {
            StocksDgv.RowTemplate.Height = 32;

            StockModel stocks = new StockModel();
            foreach (StockModel item in stocks.GetAllStocks(GlobalSettings.StoreName).ToList())
            {
                StocksDgv.Rows.Add(item.Id, item.Product, item.Description, item.Cost.ToString("N2"), item.Retail.ToString("N2"), item.WholeSale.ToString("N2"), item.Quantity, item.ReorderQty, item.Size, item.DateStamp.ToShortDateString());
            }
            LblGridItem.Text = StocksDgv.Rows.Count.ToString() + " item(s)";
            GlobalSettings.ColorGrid(StocksDgv);
        }

        private void lblRefreshGrid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StocksDgv.RowTemplate.Height = 32;

            StocksDgv.Rows.Clear();
            StockModel stocks = new StockModel();
            foreach (StockModel item in stocks.GetAllStocks(GlobalSettings.StoreName).ToList())
            {
                StocksDgv.Rows.Add(item.Id, item.Product, item.Description, item.Cost.ToString("N2"), item.Retail.ToString("N2"), item.WholeSale.ToString("N2"), item.Quantity, item.ReorderQty, item.Size, item.DateStamp.ToShortDateString());
            }
            LblGridItem.Text = StocksDgv.Rows.Count.ToString() + " item(s)";
            GlobalSettings.ColorGrid(StocksDgv);
        }

        private void SaveItemsChanges_Click(object sender, EventArgs e)
        {
            //for(int i=0; i< StocksDgv.RowCount; i++)
            //{
            //    StockModel UpdateStock = new StockModel
            //    {
            //        Id= StocksDgv.Rows[i].Cells[""].Value.ToString(),
            //        Product

            //    }
            //}
        }
    }
}
