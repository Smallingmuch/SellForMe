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
    public partial class ViewSalesForm : Form
    {
        public ViewSalesForm()
        {
            InitializeComponent();

            //Initializing All sales Components
            LoadAllSales();
        }

        public void LoadAllSales()
        {
            AllSalesDgv.RowTemplate.Height = 35;
            StockModel AllStock = new StockModel();

            SalesModel AllSales = new SalesModel();
            List<SalesModel> LoadAllSales = new List<SalesModel>();

            LoadAllSales = AllSales.GetAllSales(GlobalSettings.StoreName).ToList();
            foreach( SalesModel item in LoadAllSales)
            {
                AllSalesDgv.Rows.Add(item.Product, AllStock.GetAllStocks(GlobalSettings.StoreName).Where(x => x.Id == item.Product).FirstOrDefault().Product, item.InvoiceID, item.Qty, item.Rate.ToString("N2"), item.Discount.ToString("N2"), item.DateStamp.ToShortDateString(), item.User);
            }
            GlobalSettings.ColorGrid(AllSalesDgv);
           
        }

        private void ViewSalesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
