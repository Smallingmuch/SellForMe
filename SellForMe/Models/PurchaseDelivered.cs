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
   public class PurchaseDelivered
    {
        public int No { get; set; }
        public string ItemCode { get; set; }
        public decimal Rate { get; set; }
        public int Qty { get; set; }
        public decimal TotalAmount { get; set; }
        public string ReceivedFrom { get; set; }
        public string ReceivedBy { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string BatchNumber { get; set; }
        public string Remarks { get; set; }
        public string WayBillNo { get; set; }
        public string PaymentMethod { get; set; }
        public string BusinessName { get; set; }
        

        public bool AddPurchase()
        {
            using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                //string query = "INSERT INTO App (BusinessName, RegNo, About, Address, Phone, Email, Logo, ShowRegNoOnInvoice, AllowInvoiceReprint, DateStamp) " +
                //    "values (@BusinessName, @RegNo, @About, @Address, @Phone, @Email, @Logo, @ShowRegNoOnInvoice, @AllowInvoiceReprint, @DateStamp)";

                string query = "AddPurchase";


                var purchase = new DynamicParameters();
                purchase.Add("@ItemCode", ItemCode);
                purchase.Add("@Rate", Rate);
                purchase.Add("@Qty", Qty);
                purchase.Add("@TotalAmount", TotalAmount);
                purchase.Add("@ReceivedFrom", ReceivedFrom);
                purchase.Add("@ReceivedBy", ReceivedBy);
                purchase.Add("@ReceivedDate", ReceivedDate.ToShortDateString());
                purchase.Add("@BatchNumber", BatchNumber);
                purchase.Add("@Remarks", Remarks);
                purchase.Add("@WayBillNo", WayBillNo);
                purchase.Add("PaymentMethod", PaymentMethod);
                purchase.Add("@BusinessName", BusinessName);

                try
                {
                    con.Execute(query, purchase, commandType: CommandType.StoredProcedure);

                    return true;
                }
                catch (Exception ex)
                {
                    GlobalSettings.ErrorMsg = ex.Message.ToString();
                    return false;
                }
            }
        }


    }
}
