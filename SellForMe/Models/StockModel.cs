using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SellForMe.Models
{
    class StockModel
    {
        public string Id { get; set; }
        public string Product { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public decimal Retail { get; set; }
        public decimal WholeSale {get; set;}
        public string Size { get; set; }
        public int Quantity { get; set; }
        public int ReorderQty { get; set; }

        public DateTime DateStamp { get; set; }
        public string BusinessName { get; set; }


        public bool AddStock()
        {
          //  Thread.Sleep(1000);
            using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                //string query = "INSERT INTO App (BusinessName, RegNo, About, Address, Phone, Email, Logo, ShowRegNoOnInvoice, AllowInvoiceReprint, DateStamp) " +
                //    "values (@BusinessName, @RegNo, @About, @Address, @Phone, @Email, @Logo, @ShowRegNoOnInvoice, @AllowInvoiceReprint, @DateStamp)";

                string query = "AddStocks";


                var stock = new DynamicParameters();

                stock.Add("@Id", Id);
                stock.Add("@Product", Product);
                stock.Add("@Description", Description);
                stock.Add("@Cost", Cost);
                stock.Add("@Retail", Retail);
                stock.Add("@Wholesale", WholeSale);
                stock.Add("@Quantity", Quantity);
                stock.Add("@ReorderQty", ReorderQty);
                stock.Add("@Size", Size);
                stock.Add("@DateStamp", DateTime.UtcNow.ToShortDateString());
                stock.Add("@BusinessName", BusinessName);

                try
                {
                    con.Execute(query, stock, commandType: CommandType.StoredProcedure);

                    return true;
                }
                catch (Exception ex)
                {
                   GlobalSettings.ErrorMsg= ex.Message.ToString();
                    return false;
                }
            }

        }

        public bool UpDateStockQty(string BusinessName, int Qty, string Id)
        {
            //  Thread.Sleep(1000);
            using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                string query = "UPDATE Stocks SET Quantity=@Quantity where BusinessName=@BusinessName and Id=@Id";

                //string query = "UpdateStocks";
                var stock = new DynamicParameters();               
                stock.Add("@Quantity", Qty);
                stock.Add("@BusinessName", BusinessName);
                stock.Add("@Id", Id);

                try
                {
                    con.Execute(query, stock, commandType: CommandType.Text);

                    return true;
                }
                catch (Exception ex)
                {
                    GlobalSettings.ErrorMsg = ex.Message.ToString();
                    return false;
                }
            }

        }


        public List<StockModel> GetAllStocks(string storeName)
        {
            List<StockModel> stock = new List<StockModel>();
            using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                string commandText = "GetAllStocks";
                // string commandText = "SELECT * FROM Stocks WHERE BusinessName=@BusinessName";
                var store = new DynamicParameters();
                store.Add("@BusinessName", storeName);

                try
                {

                    stock = con.Query<StockModel>(commandText, store, commandType: CommandType.StoredProcedure).ToList();                    
                    return stock;
                }
                catch (Exception ex)
                {
                    GlobalSettings.ErrorMsg = ex.Message.ToString();
                    //throw ex;
                    return stock;
                }

            }
        }


        public StockModel GetStockByNameAndStoreName(string product, string storeName)
        {
            //StoreModel output;
            return GetAllStocks(storeName).Where(x => x.Product == product).FirstOrDefault();
            //output;

        }
    }
}
