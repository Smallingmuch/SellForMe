using SellForMe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace SellForMe
{
    public partial class ImportStockForm : Form
    {
        GlobalSettings NewStock = new GlobalSettings();
        DataTable dtExcel = new DataTable();

        string filePath = string.Empty;
        string fileExt = string.Empty;
        public ImportStockForm()
        {
            InitializeComponent();
        }

        private void ImportStockButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ValidateNames = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath = file.FileName;
                fileExt = Path.GetExtension(filePath);
                StockPathTextbox.Text = filePath;

                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        if (dtExcel == null)
                        {
                            MessageBox.Show("Error Occured!!! \n1. Make sure to close or resave the Excel Document and \n2. Restart the application.\n3. Check Task Manager and close all Opened Excel Document.", "Spelling Bee 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {

                            Cursor.Current = Cursors.WaitCursor;
                            Excel.Application oxl = new Excel.Application();
                            Excel.Workbook sheets = oxl.Workbooks.Open(filePath);

                            SheetsCbo.Items.Clear();
                            for (int i = 1; i <= sheets.Sheets.Count; i++)
                            {
                                SheetsCbo.Items.Add(sheets.Sheets[i].Name);
                            }
                            SheetsCbo.SelectedIndex = 0;

                            //Count = 0;
                           
                            dtExcel = NewStock.ReadExcel(filePath, SheetsCbo.Text,  fileExt);
                           ImportStockGrid.DataSource = dtExcel;
                            GlobalSettings.ColorGrid(ImportStockGrid);

                            DgvRowCount.Text = ImportStockGrid.Rows.Count.ToString() + " records available";

                            Cursor.Current = Cursors.Default;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Choose an Excel file only with .xls or .xlsx as extension", "Spelling Bee 1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    StockPathTextbox.Clear();
                }
            }
        }

        private void SheetsCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DgvRowCount.Text = ImportStockGrid.Rows.Count.ToString() + " records available";
            dtExcel = NewStock.ReadExcel(filePath, SheetsCbo.Text, fileExt);
            if (dtExcel == null)
            {
                MessageBox.Show("Error Occured!!! \n1. Make sure to close or resave the Excel Document and \n2. Restart the application.\n3. Check Task Manager and close all Opened Excel Document.", "Spelling Bee 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ImportStockGrid.RowTemplate.Height = 35;
                ImportStockGrid.DataSource = dtExcel;
                
                GlobalSettings.ColorGrid(ImportStockGrid);
                DgvRowCount.Text = ImportStockGrid.Rows.Count.ToString() + " records available";
                AddStockButton.Visible = true;
            }

        }

        private void ImportStockForm_Load(object sender, EventArgs e)
        {
            AddStockButton.Visible = false;
            lblSavedItems.Text = "0";
            lblAddingItems.Visible = false;
        }

        public void CheckGridColumnCountAndHeaderDetails()
        {
            if (ImportStockGrid.Columns.Count > 8 || ImportStockGrid.Columns.Count < 8)
            {
                MessageBox.Show("Please check your table arrangement!!!", "Sell For Me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ImportStockGrid.Columns.Count == 8)
            {
                if (ImportStockGrid.Columns[0].HeaderText != "ItemName" || ImportStockGrid.Columns[1].HeaderText != "Description" ||
               ImportStockGrid.Columns[2].HeaderText != "Cost" || ImportStockGrid.Columns[3].HeaderText != "Retail" ||
               ImportStockGrid.Columns[4].HeaderText != "Wholesale" || ImportStockGrid.Columns[5].HeaderText!="Size" || 
               ImportStockGrid.Columns[6].HeaderText !="Quantity" || ImportStockGrid.Columns[7].HeaderText !="ReorderQty")
                {

                    MessageBox.Show("Your table header arrangement should be in this format \n ItemName | Description | Cost | Retail | Wholesale | Size | Quantity | ReorderQty ", "Spelling Bee 1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
            }

        }
        private void AddStockButton_Click(object sender, EventArgs e)
        {
            CheckGridColumnCountAndHeaderDetails();
            int count = 0;
            int existingItem = 0;

            ExistingItemNames.Items.Clear();
            lblAddingItems.Visible = true;
            ImportStockGrid.Columns[0].Frozen = true;
            StockModel NewStocks = new StockModel();
            for(int i = 0; i <ImportStockGrid.Rows.Count; i++){


                //ItemName | Description | Cost | Retail | Wholesale | Size | Quantity | ReorderQty
                NewStocks.Id = "ITEM-"+ GlobalSettings.RandomGuid().ToUpper();
                NewStocks.Product = ImportStockGrid.Rows[i].Cells[0].Value.ToString();
                NewStocks.Description = ImportStockGrid.Rows[i].Cells[1].Value.ToString();
                NewStocks.Cost =Convert.ToDecimal(ImportStockGrid.Rows[i].Cells[2].Value.ToString());
                NewStocks.Retail = Convert.ToDecimal(ImportStockGrid.Rows[i].Cells[3].Value.ToString());
                NewStocks.WholeSale = Convert.ToDecimal(ImportStockGrid.Rows[i].Cells[4].Value.ToString());
                NewStocks.Size = ImportStockGrid.Rows[i].Cells[5].Value.ToString();
                NewStocks.Quantity = Convert.ToInt32(ImportStockGrid.Rows[i].Cells[6].Value);
                NewStocks.ReorderQty = Convert.ToInt32(ImportStockGrid.Rows[i].Cells[7].Value);
                NewStocks.DateStamp = DateTime.Now;
                NewStocks.BusinessName = GlobalSettings.StoreName;

                if (NewStocks.AddStock())
                {
                    count++;
                    lblSavedItems.Text = Convert.ToString(count);
                    lblExistingItem.Text = Convert.ToString(existingItem);                   
                    //  MessageBox.Show("Saved!", "Sell For Me", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if(GlobalSettings.ErrorMsg.Contains("PRIMARY KEY"))
                {
                    existingItem++;
                    lblExistingItem.Text = Convert.ToString(existingItem);
                    lblSavedItems.Text = Convert.ToString(count);
                    ExistingItemNames.Items.Add(ImportStockGrid.Rows[i].Cells[0].Value.ToString());

                   // MessageBox.Show(ImportStockGrid.Rows[i].Cells[0].Value.ToString() + " \nis alread existing", "Sell For Me", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    lblSavedItems.Text = Convert.ToString(count);
                    lblExistingItem.Text = Convert.ToString(existingItem);
                    MessageBox.Show(GlobalSettings.ErrorMsg.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Thread.Sleep(800);
            lblAddingItems.Visible = false;
            MessageBox.Show("Adding Stocks Completed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // SheetsCbo.Items.RemoveAt(0);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalSettings.RandomCode();
        }
    }
}
