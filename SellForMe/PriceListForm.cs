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
    public partial class PriceListForm : Form
    {
        public PriceListForm()
        {
            InitializeComponent();
        }

        private void PriceListForm_Load(object sender, EventArgs e)
        {
            PriceListDgv.RowTemplate.Height = 35;
            StockModel Allstocks = new StockModel();
            PriceListDgv.Rows.Clear();
            foreach(StockModel stock in Allstocks.GetAllStocks(GlobalSettings.StoreName))
            {
                PriceListDgv.Rows.Add(stock.Product, stock.Retail.ToString("N2"), stock.WholeSale.ToString("N2"));
            }
            GlobalSettings.ColorGrid(PriceListDgv);
        }
    }
}
