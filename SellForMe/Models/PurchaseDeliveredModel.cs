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
   public class PurchaseDeliveredModel
    {
        public string ItemCode { get; set; }
        public decimal Rate { get; set; }
        public int Qty { get; set; }
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
                string query = "AddPurchase";

                var item = new DynamicParameters();

                item.Add(ItemCode);
                item.Add(Rate.ToString());
                item.Add(Qty.ToString());;
                item.Add( ReceivedFrom);
                item.Add(ReceivedBy);
                item.Add(ReceivedDate.ToShortDateString());
                item.Add(BatchNumber);
                item.Add(Remarks);
                item.Add(WayBillNo);
                item.Add(PaymentMethod);
                item.Add(BusinessName);

                try
                {
                    con.Execute(query, item, commandType: CommandType.StoredProcedure);

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
