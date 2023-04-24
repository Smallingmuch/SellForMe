using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellForMe.Models
{
    class SalesModel
    {
        public string Product { get; set; }
        public string SalesType { get; set; }
        public string InvoiceID { get; set;}
        public int Qty { get; set; }
        public decimal Discount { get; set; }
        public decimal Rate { get; set; }
        public string Remark { get; set; }
        public string User { get; set; }
        public string BusinessName { get; set; }
        public DateTime DateStamp { get; set; }


        public bool MakeSales()        
        {           
                //  Thread.Sleep(1000);
                using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
                {
                    string query = "INSERT INTO Sales (Product, SalesType, InvoiceID, Qty, Discount, Rate, Remark, [User], BusinessName, DateStamp) " +
                      "values (@Product, @SalesType, @InvoiceID, @Qty, @Discount, @Rate, @Remark, @User, @BusinessName, @DateStamp)";

                    //string query = "AddStocks";

                    var item = new DynamicParameters();
                    item.Add("@Product", Product);
                    item.Add("@SalesType", SalesType);
                    item.Add("@InvoiceID", InvoiceID);
                    item.Add("@Qty", Qty);
                    item.Add("@Discount", Discount);
                    item.Add("@Rate", Rate);
                    item.Add("@Remark", Remark);
                    item.Add("@User", User);
                    item.Add("@BusinessName", BusinessName);
                    item.Add("@DateStamp", DateTime.UtcNow.ToShortDateString());                    

                    try
                    {
                        con.Execute(query, item, commandType: CommandType.Text);

                        return true;
                    }
                    catch (Exception ex)
                    {
                        GlobalSettings.ErrorMsg = ex.Message.ToString();
                        return false;
                    }
                }

            
        }

        public List<SalesModel> GetAllSales(string storeName)
        {
            List<SalesModel> stock = new List<SalesModel>();
            using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                string commandText = "GetAllSales";
                // string commandText = "SELECT * FROM Stocks WHERE BusinessName=@BusinessName";
                var store = new DynamicParameters();
                store.Add("@BusinessName", storeName);

                try
                {
                    stock = con.Query<SalesModel>(commandText, store, commandType: CommandType.StoredProcedure).ToList();
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
    }
}
