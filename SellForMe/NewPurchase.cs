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
    public partial class NewPurchase : Form
    {
        public NewPurchase()
        {
            InitializeComponent();
        }

   

        private void cboPmtMethod_TextChanged(object sender, EventArgs e)
        {
            if (cboPmtMethod.Text.ToString() == "Credit Facility")
            {

                lblAmountPaid.Visible = false;
                txtAmountPaid.Visible = false;
                PmtMethodGroup.Height = 100;
            }
            else
            {
                lblAmountPaid.Visible = true;
                txtAmountPaid.Visible = true;
                PmtMethodGroup.Height = 160;
            }
        }

        private void NewPurchase_Load(object sender, EventArgs e)
        {
            StockModel allStocks = new StockModel();
           ProductsGrid.RowTemplate.Height = 35;

            foreach (StockModel item in allStocks.GetAllStocks(" - Beauty by Teji"))
            {

                ItemNames.Items.Add(item.Product.ToString());
                //ProductsGrid.Rows[0].Cells[0].Value = item.Product.ToString();
                //ProductsGrid.Rows[0].Cells[1].Value = 1;
                //ProductsGrid.Rows[0].Cells[2].Value = item.Cost.ToString("N2");
               
                //ProductsGrid.Rows[0].Cells[4].Value = 0.00.ToString("N2");

                //int qty = Convert.ToInt32( ProductsGrid.Rows[0].Cells[1].Value);
                //decimal cost =Convert.ToDecimal( ProductsGrid.Rows[0].Cells[2].Value);

                //ProductsGrid.Rows[0].Cells[3].Value = (qty * cost).ToString("N2");
            }
            GlobalSettings.ColorGrid(ProductsGrid);
        }

        private void NewPurchase_Activated(object sender, EventArgs e)
        {
        }

        private void SavePurchaseButton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<ProductsGrid.RowCount-1; i++)
            {
                PurchaseDeliveredModel purchase = new PurchaseDeliveredModel
                {
                    ItemCode = "ITEM-" + GlobalSettings.RandomGuid(),
                    Rate = Convert.ToDecimal( ProductsGrid.Rows[i].Cells[0].Value),
                    Qty = Convert.ToInt32(ProductsGrid.Rows[i].Cells[2].Value),
                    ReceivedFrom = cboSupplier.Text,
                    ReceivedDate=Convert.ToDateTime( dtpPurchaseDate.Text),
                    BatchNumber = txtBatchNo.Text,
                    Remarks = txtRemark.Text,
                    WayBillNo = txtWaybillNo.Text,
                    PaymentMethod = cboPmtMethod.Text,
                    BusinessName= GlobalSettings.StoreName


                };
                if (purchase.AddPurchase())
                {
                    MessageBox.Show("Purchase Added", "Sell For Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(GlobalSettings.ErrorMsg.ToString(), "Sell For Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void ProductsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void SumAll()
        {
            decimal allTotalCost=0;
            decimal allDiscount = 0;
            for(int i =0; i<ProductsGrid.RowCount-1; i++)
            {
                allTotalCost += Convert.ToDecimal(ProductsGrid.Rows[i].Cells[3].Value);
                allDiscount += Convert.ToDecimal(ProductsGrid.Rows[i].Cells[4].Value);
            }
            lblTotalInvoice.Text= (allTotalCost - allDiscount).ToString("N2");
        }
        private void ProductsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductsGrid.CurrentCell.ColumnIndex == 0)
            {
                StockModel allstock = new StockModel();
                StockModel stocks;
                stocks= allstock.GetStockByNameAndStoreName(" - Beauty by Teji", ProductsGrid.CurrentRow.Cells[0].Value.ToString());               
                ProductsGrid.CurrentRow.Cells[1].Value = 1;
                ProductsGrid.CurrentRow.Cells[2].Value = stocks.Cost.ToString("N2");
                ProductsGrid.CurrentRow.Cells[4].Value = 0.00.ToString("N2");
                int qty = Convert.ToInt32(ProductsGrid.CurrentRow.Cells[1].Value);
                decimal cost = Convert.ToDecimal(ProductsGrid.CurrentRow.Cells[2].Value);
                ProductsGrid.CurrentRow.Cells[3].Value = (qty * cost).ToString("N2");
            }

            if (ProductsGrid.CurrentCell.ColumnIndex == 1 || ProductsGrid.CurrentCell.ColumnIndex==2 || ProductsGrid.CurrentCell.ColumnIndex==4)
            {
                int qty = Convert.ToInt32(ProductsGrid.CurrentRow.Cells[1].Value);
                decimal cost = Convert.ToDecimal(ProductsGrid.CurrentRow.Cells[2].Value);
                ProductsGrid.CurrentRow.Cells[3].Value = (qty * cost).ToString("N2");
                ProductsGrid.CurrentRow.Cells[2].Value=cost.ToString("N2");
                decimal discount = Convert.ToDecimal(ProductsGrid.CurrentRow.Cells[4].Value);
                ProductsGrid.CurrentRow.Cells[4].Value = discount.ToString("N2");
            }

            SumAll();

        }
    }
}
