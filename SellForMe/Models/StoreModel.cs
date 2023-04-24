using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellForMe.Models
{
    class StoreModel
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string RegNo { get; set; }
        public string About { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[] Logo { get; set; }
        public byte ShowRegNoOnInvoice { get; set; }
        public byte AllowInvoiceReprint { get; set; }
        public string Manager { get; set; }
        public DateTime DataStamp { get; set; }


        public bool AddStore()
        {
            using(IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                //string query = "INSERT INTO App (BusinessName, RegNo, About, Address, Phone, Email, Logo, ShowRegNoOnInvoice, AllowInvoiceReprint, DateStamp) " +
                //    "values (@BusinessName, @RegNo, @About, @Address, @Phone, @Email, @Logo, @ShowRegNoOnInvoice, @AllowInvoiceReprint, @DateStamp)";

                string query = "AddStore";


                var store = new DynamicParameters();

                store.Add("@BusinessName", BusinessName);
                store.Add("@RegNo", RegNo);
                store.Add("@About", About);
                store.Add("@Address", Address);
                store.Add("@Phone", Phone);
                store.Add("@Email", Email);
                store.Add("@Logo", Logo, dbType: DbType.Binary);                            
                store.Add("@ShowRegNoOnInvoice", ShowRegNoOnInvoice);
                store.Add("@AllowInvoiceReprint", AllowInvoiceReprint);
                store.Add("@Manager", Manager);
                store.Add("@DateStamp", DateTime.UtcNow.ToShortDateString());

                try
                {                    
                   con.Execute(query, store, commandType: CommandType.StoredProcedure);

                 return true;
                 }
            catch (Exception ex)
                {
                  GlobalSettings.ErrorMsg=  ex.Message.ToString();
                    return false;
                }
            }
            
        }


        public bool UpDateStore()
        {
            using(IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                string query= "UPDATE App SET BusinessName=@BusinessName, RegNo=@RegNo, About=@About, " +
                    "Address=@Address, Phone=@Phone, Email=@Email, Logo=@Logo, ShowRegNoOnInvoice=@ShowRegNoOnInvoice, " +
                    "Manager=@Manager, AllowInvoiceReprint= @AllowInvoiceReprint  WHERE Id=@Id";


                var store = new DynamicParameters();

                store.Add("@BusinessName", BusinessName);
                store.Add("@RegNo", RegNo);
                store.Add("@About", About);
                store.Add("@Address", Address);
                store.Add("@Phone", Phone);
                store.Add("@Email", Email);
                store.Add("@Logo", Logo, dbType: DbType.Binary);
                store.Add("@ShowRegNoOnInvoice", ShowRegNoOnInvoice);
                store.Add("@AllowInvoiceReprint", AllowInvoiceReprint);
                store.Add("@Manager", Manager);
                store.Add("@Id", Id);

                try
                {
                    con.Execute(query, store, commandType: CommandType.Text);

                    return true;
                }
                catch (Exception ex)
                {
                  GlobalSettings.ErrorMsg=  ex.Message.ToString();
                    return false;
                }

            }
        }
         public List<StoreModel> GetAllStores()
        {
            List<StoreModel> stores = new List<StoreModel>();
            using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                string commandText = "SELECT * FROM App";
                try
                {
                stores = con.Query<StoreModel>(commandText, commandType: CommandType.Text).ToList();
                return stores;
                }
                catch (Exception ex)
                {
                  GlobalSettings.ErrorMsg=  ex.Message.ToString();
                    return null;
                }
                
            }
        }


        public StoreModel GetStoreByName(string storeName)
        {
            //StoreModel output;
           return GetAllStores().Where(x => x.BusinessName == storeName).FirstOrDefault();
            //output;
            
        }
        public bool DeleteStore(int id  )
        {
            
            using(IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                string query = "DELETE FROM App WHERE Id=@Id";

                var store = new DynamicParameters();
                store.Add("@Id", id);

                try
                {
                    con.Execute(query, store, commandType: CommandType.Text);
                    return true;
                }
                catch (Exception ex)
                {
                   GlobalSettings.ErrorMsg= ex.Message.ToString();
                    return false;
                }
            }
        }
       
    }
}
