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
    public partial class PurchaseItem : Form
    {
        public PurchaseItem()
        {
            InitializeComponent();

            StockModel AllStocks = new StockModel();
            StockName.Items.Clear();
            foreach(StockModel item in AllStocks.GetAllStocks(GlobalSettings.StoreName).ToList())
            {
                StockName.Items.Add(item.Product);
            }            
            foreach(DataGridViewRow x in PurchaseGrid.Rows)
            {
                x.MinimumHeight = 40;
            }
            //PurchaseGrid.Row Template.MinimumHeight = 35;

            GlobalSettings.ColorGrid(PurchaseGrid);

        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
