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
    class CustomerModel
    {
        public int CustomerId { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string HomeAddress { get; set; }
        public DateTime DateStamp { get; set; }
        public string BusinessName { get; set; }

        public bool CreateCustomer()
        {
            using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                string query = "INSERT INTO Customers (FullName, Phone, Email, State, City, HomeAddress, DateStamp)" +
                    "VALUES (@Fullname, @Phone, @Email, @State, @City, @HomeAddress, @DateStamp)";

                var customer = new DynamicParameters();
                customer.Add("@Fullname", Fullname);
                customer.Add("@Phone", Phone);
                customer.Add("@Email", Email);
                customer.Add("@State", State);
                customer.Add("@City", City);
                customer.Add("@HomeAddress", HomeAddress);
                customer.Add("@DateStamp", DateTime.UtcNow.ToShortDateString());

                try
                {
                    con.Execute(query, customer, commandType: CommandType.Text);
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool UpdateCustomer(int CusId)
        {
            using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                string query = "UPDATE Customers SET FullName=@Fullname, Phone=@Phone, Email=@Email, " +
                    "State=@State, City=@City, HomeAddress=@HomeAddress WHERE CustomerID=@CustomerID";
                  

                var customer = new DynamicParameters();
                customer.Add("@Fullname", Fullname);
                customer.Add("@Phone", Phone);
                customer.Add("@Email", Email);
                customer.Add("@State", State);
                customer.Add("@City", City);
                customer.Add("@HomeAddress", HomeAddress);
                customer.Add("@CustomerID", CusId);

                try
                {
                    con.Execute(query, customer, commandType: CommandType.Text);
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<CustomerModel> GetCustomers( string BusinessName)
        {
            List<CustomerModel> customers = new List<CustomerModel>();
            using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                string query = "SELECT * FROM Customers WHERE BusinessName=@BusinessName";
                var customer = new DynamicParameters();
                customer.Add("@BusinessName", BusinessName);
                try
                {
                    customers = con.Query<CustomerModel>(query, customer, commandType: CommandType.Text).ToList();
                    return customers;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        public bool DeleteCustomer(string CusId)
        {

            using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                string query = "DELETE FROM Customer WHERE CustomerID=@CustomerID";

                var customer = new DynamicParameters();
                customer.Add("@CustomerID", CusId);

                try
                {
                    con.Execute(query, customer, commandType: CommandType.Text);
                    return true;
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                    throw ex;
                    return false;
                }
            }
        }
    }
}
