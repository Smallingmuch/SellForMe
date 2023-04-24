using SellForMe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellForMe
{
    public partial class SalesForm : Form
    {
        public int i;
        public SalesForm()
        {
            InitializeComponent();

            //Self Defined Component by the Programmer
            InitializeBindings();
            UsersModel UserFullname = new UsersModel();
            LoggedInCashier.Text = UserFullname.GetUser(GlobalSettings.User).Fullname;

            InvoiceID.Text = "INVOICE-" + GlobalSettings.RandomCode();

        }

        public void BalOrChange()
        {
            if (ChangeLabel.Text.StartsWith("-"))
            {
                BalanceOrChange.Text = "Balance";
            }
            else
            {
                BalanceOrChange.Text = "Change?";
            }
        }
        public DataGridViewCell SearchGrid(string searchText, DataGridView dataGridView, int columnIndex)
        {
            DataGridViewCell FoundText = null;


            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                if(row.Cells[columnIndex].Value !=null && searchText == row.Cells[columnIndex].ToString())
                {
                    FoundText = row.Cells[columnIndex];
                    break;
                }
            }
            return FoundText;
        }

        private void ItemNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SalesItemGridView.Rows.Count >= 1)
            {
                string searchValue = ItemNames.Text;
                List<string> ItemList = new List<string>();
                for (int i = 0; i < SalesItemGridView.RowCount; i++)
                {
                    ItemList.Add(SalesItemGridView.Rows[i].Cells["ItemName"].Value.ToString());
                }
                if (ItemList.Contains(searchValue))
                {
                    MessageBox.Show("Item already added", "Sell For Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    StockModel allstocks = new StockModel().GetStockByNameAndStoreName(ItemNames.Text, GlobalSettings.StoreName);
                    SalesItemGridView.Rows.Add(allstocks.Id, ItemNames.Text, allstocks.Size, 1, allstocks.Retail.ToString("N2"), (1 * allstocks.Retail).ToString("N2"), (1*0).ToString("N2"), allstocks.Description);                                     
                }                
            }
            else
            {
                StockModel allstocks = new StockModel().GetStockByNameAndStoreName(ItemNames.Text, GlobalSettings.StoreName);
                SalesItemGridView.Rows.Add(allstocks.Id, ItemNames.Text, allstocks.Size, 1, allstocks.Retail.ToString("N2"), (1 * allstocks.Retail).ToString("N2"), (1 * 0).ToString("N2"), allstocks.Description);              
            }
            TotalItemsLabel.Text = SalesItemGridView.RowCount.ToString() + " item(s)";
            SalesItemGridView.RowTemplate.Height = 25;
            GlobalSettings.ColorGrid(SalesItemGridView);
            SubTotal();
        }
        private void EditDataGridViewCell(object sender, DataGridViewCellEventArgs e)
        {
            decimal total;

            decimal price = Convert.ToDecimal(SalesItemGridView.CurrentRow.Cells["UnitPrice"].Value);
            decimal qty = Convert.ToDecimal(SalesItemGridView.CurrentRow.Cells["Qty"].Value);
            decimal discount = Convert.ToDecimal(SalesItemGridView.CurrentRow.Cells["Discount"].Value);

                 total= qty * price;                
            
            SalesItemGridView.CurrentRow.Cells["TotalAmount"].Value = total.ToString("N2");           
            SalesItemGridView.CurrentRow.Cells["Discount"].Value = discount.ToString("N2");
            SubTotal();
        }
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            for(int i=0; i<=SalesItemGridView.RowCount-1; i++)
            {
                //listBox1.Items.Add(SalesItemGridView.Rows[i].Cells[1].Value);
            }
           SalesItemGridView.Rows.Clear();
            TotalItemsLabel.Text = SalesItemGridView.RowCount.ToString() + " item(s)";
        }
        private void RowDeleted(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TotalItemsLabel.Text = SalesItemGridView.RowCount.ToString() + " item(s)";
            SubTotal();
        }
        private void InitializeBindings()
        {
            StockModel allStocks = new StockModel();
            SalesItemGridView.RowTemplate.Height = 35;

            ItemNames.Items.Clear();
            foreach (StockModel item in allStocks.GetAllStocks(GlobalSettings.StoreName))
            {
                ItemNames.Items.Add(item.Product.ToString());
            }
            GlobalSettings.ColorGrid(SalesItemGridView);
        }  
        private void CancelSalesButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SalesItemGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if(e.Exception.Message=="DataGridviewComboboxcell value is not valid.")
            {
                object value = SalesItemGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)SalesItemGridView.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    e.ThrowException = false;
                }

            }
        }

        private void DiscountChk_CheckedChanged(object sender, EventArgs e)
        {
            SubTotal();
        }
        public void SubTotal()
        {
            decimal subtotal = 0;
            decimal discounttotal =0;
            decimal Overalltotal;

            if (DiscountChk.Checked)
            {
                DiscountTotalText.ReadOnly = false;
                for (int i = 0; i < SalesItemGridView.RowCount; i++)
                {
                    SalesItemGridView.Rows[i].Cells["Discount"].ReadOnly = true;
                    SalesItemGridView.Rows[i].Cells["Discount"].Value = "0.00";

                }
                DiscountTotalLabel.Text = "0.00";
                ChangeLabel.Text ="0.00";
                Overalltotal = Convert.ToDecimal(SubTotalLabel.Text) - Convert.ToDecimal(DiscountTotalText.Text);
                TotalLabel.Text = Overalltotal.ToString("N2");

                ChangeLabel.Text = Convert.ToDecimal(Convert.ToDecimal(AmountTendered.Text) - Overalltotal).ToString("N2");
            }
            else
            {

                DiscountTotalText.ReadOnly = true;
                DiscountTotalText.Text = "0.00";
                //for(int j = 0; j<SalesItemGridView.RowCount; j++)
                //{
                    
                //    //SalesItemGridView.Rows[j].Cells["Discount"].Value = "0.00";
                //}                
                for (int i = 0; i < SalesItemGridView.RowCount; i++)
                {
                    SalesItemGridView.Rows[i].Cells["Discount"].ReadOnly = false;
                    subtotal+=Convert.ToDecimal(SalesItemGridView.Rows[i].Cells["TotalAmount"].Value.ToString());
                    discounttotal += Convert.ToDecimal(SalesItemGridView.Rows[i].Cells["Discount"].Value.ToString());

                }
                SubTotalLabel.Text = Convert.ToString(subtotal.ToString("N2")); 
                DiscountTotalLabel.Text= Convert.ToString(discounttotal.ToString("N2"));
           
                Overalltotal=Convert.ToDecimal(SubTotalLabel.Text) - Convert.ToDecimal(DiscountTotalLabel.Text);
                TotalLabel.Text = Overalltotal.ToString("N2");
            }

            BalOrChange();
        }
        public void DeductTotalPayFromAmount()
        {
            if (AmountTendered.Text == "" || AmountTendered.Text == " ")
            {
                ChangeLabel.Text = "0.00";
                MessageBox.Show("Enter valid amount", "Sell for Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // AmountTendered.Text.All(char.IsDigit)

            if (Regex.IsMatch(AmountTendered.Text.Trim(), @"\d+$"))
            {
                ChangeLabel.Text = Convert.ToDecimal(Convert.ToDecimal(AmountTendered.Text) - Convert.ToDecimal(TotalLabel.Text)).ToString("N2");
                BalOrChange();
            }
            else
            {
                MessageBox.Show("Enter amount in numbers only\n- Alphabets and Symbols not allowed.", "Sell for Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void AmountTendered_TextChanged(object sender, EventArgs e)
        {
            DeductTotalPayFromAmount();
        }
        private void DiscountTotalText_TextChanged(object sender, EventArgs e)
        {
            TotalLabel.Text = Convert.ToDecimal(Convert.ToDecimal(SubTotalLabel.Text) - Convert.ToDecimal(DiscountTotalText.Text)).ToString("N2");
            
            ChangeLabel.Text = Convert.ToDecimal( Convert.ToDecimal(AmountTendered.Text) - Convert.ToDecimal(TotalLabel.Text)).ToString("N2");
            BalOrChange();
        }      

        private void AmountTendered_Leave(object sender, EventArgs e)
        {
            if(AmountTendered.Text == "" || !AmountTendered.Text.Trim().All(char.IsDigit))
            {
                AmountTendered.Text = "0.00";
                ChangeLabel.Text = TotalLabel.Text;
            }            
            else
            {
               AmountTendered.Text =Convert.ToDecimal(AmountTendered.Text).ToString("N2");
            }          
        }

        private void SubTotalLabel_TextChanged(object sender, EventArgs e)
        {
            SubTotal();
            DeductTotalPayFromAmount();
        }

        private void DiscountTotalLabel_Click(object sender, EventArgs e)
        {
            DeductTotalPayFromAmount();
        }
        private void MakeSalesButton_Click(object sender, EventArgs e)
        {
            string TypeOfSales;
            if (RdoWholesale.Checked == true)
            {
                TypeOfSales = RdoWholesale.Text;
            }
            else
            {
                TypeOfSales = RdoRetail.Text;
            }
            for (int i=0; i<=SalesItemGridView.RowCount-1; i++)
            {
                //MessageBox.Show(SalesItemGridView.Rows[i].Cells["ItemCode"].Value.ToString());
                SalesModel NewSales = new SalesModel
                {
                    Product = SalesItemGridView.Rows[i].Cells["ItemCode"].Value.ToString(),
                    SalesType = TypeOfSales,
                    InvoiceID = InvoiceID.Text,
                    Qty = Convert.ToInt32(SalesItemGridView.Rows[i].Cells["Qty"].Value.ToString()),
                    Discount = Convert.ToDecimal(SalesItemGridView.Rows[i].Cells["Discount"].Value.ToString()),
                    Rate = Convert.ToDecimal(SalesItemGridView.Rows[i].Cells["TotalAmount"].Value.ToString()),
                    Remark = "All item(s) in Good Condition",
                    User = GlobalSettings.User,
                    BusinessName = GlobalSettings.StoreName                    
                };
                                
                if (!NewSales.MakeSales())
                {
                    MessageBox.Show("Error: "+ GlobalSettings.ErrorMsg, "Sell for Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InvoiceID.Text = "INVOICE-" + GlobalSettings.RandomCode();
                    return;
                }

                //Code below Reads and Deducts the Purchased Quantity from the Available Quantity then updates the Available Quantity for proper recording
                StockModel AllStock = new StockModel();
                int OldQty = 0;
                int NewQty=0;
                OldQty = Convert.ToInt32(AllStock.GetAllStocks(GlobalSettings.StoreName).Where(x => x.Id == SalesItemGridView.Rows[i].Cells["ItemCode"].Value.ToString()).FirstOrDefault().Quantity);
                NewQty = OldQty - Convert.ToInt32(SalesItemGridView.Rows[i].Cells["Qty"].Value.ToString());
                AllStock.UpDateStockQty(GlobalSettings.StoreName, NewQty, SalesItemGridView.Rows[i].Cells["ItemCode"].Value.ToString());

            }
            MessageBox.Show("Sales made successfully", "Sell for Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InvoiceID.Text = "INVOICE-" + GlobalSettings.RandomCode();



        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
