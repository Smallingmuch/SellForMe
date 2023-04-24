using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SellForMe.Models
{
    class UsersModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Passkey { get; set; }
        public string Role { get; set; }
        public DateTime DataStamp { get; set; }
        public string BusinessName { get; set; }

        public bool CreateUser()
        {

            using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {

                string query = "INSERT INTO Users (Username, Fullname, Passkey, Role, DateStamp, BusinessName)" +
               "VALUES (@Username, @Fullname, @Passkey, @Role, @DateStamp, @BusinessName)";

                var User = new DynamicParameters();
                User.Add("@Username", Username);
                User.Add("@Fullname", Fullname);
                User.Add("@Passkey", GlobalSettings.EncryptPasskey(Passkey));
                User.Add("@Role", Role);
                User.Add("@DateStamp", DateTime.UtcNow.ToShortDateString());
                User.Add("@BusinessName", GlobalSettings.StoreName);
                try
                {
                    con.Execute(query, User, commandType: CommandType.Text);
                    return true;
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                    return false;
                    //throw ex;
                }
            }


        }


        public bool UpdateUser(string SelectedUsername)
        {

            using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                string query = "UPDATE [dbo].[Users] SET [Fullname]=@Fullname," +
                    "[Role]=@Role, Passkey=@Passkey WHERE [Username]=@Username";

                var user = new DynamicParameters();
               
                user.Add("@Fullname", Fullname);
                user.Add("@Role", Role);
                user.Add("@Passkey", Passkey);
                user.Add("@Username", SelectedUsername);
                try
                {
                    con.Execute(query, user, commandType: CommandType.Text);
                    return true;
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                    throw ex;
                }

            }


        }

        public List<UsersModel> GetStoreUsers()
        {
            List<UsersModel> storeUser = new List<UsersModel>();
            using (IDbConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                string query = "SELECT * FROM Users";
                //string query = "SELECT * FROM Users WHERE BusinessName=@BusinessName";
                //var StoreUser = new DynamicParameters();
                //StoreUser.Add("@BusinessName", BusinessName);
                try
                {
                    storeUser = con.Query<UsersModel>(query, commandType: CommandType.Text).ToList();
                    //storeUser = con.Query<UsersModel>(query, storeUser, commandType: CommandType.Text).ToList();
                    return storeUser;
                }
                catch (Exception ex)
                {
                    GlobalSettings.ErrorMsg = ex.Message.ToString();
                    return null;
                }

            }
        }
        public List<UsersModel> GetAllUsers()
        {
            List<UsersModel> output = new List<UsersModel>();

            using (SqlConnection con = new SqlConnection(GlobalSettings.ConString))
            {
                string CommandText = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(CommandText, con);
                con.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            UsersModel user = new UsersModel()
                            {
                                //Id=rd[]
                                Username = rd["Username"].ToString(),
                                Fullname = rd["Fullname"].ToString(),
                                Passkey = rd["Passkey"].ToString(),
                                Role = rd["Role"].ToString(),
                                DataStamp = Convert.ToDateTime(rd["Datestamp"].ToString())
                            };
                            output.Add(user);
                        }
                    }

                }
                return output;
            }




        }

        public UsersModel GetUser(string username)
        {
            UsersModel output = new UsersModel();
            output = GetStoreUsers().Where(x => x.Username == username).FirstOrDefault();
            return output;
        }

        public bool ChangePassword(string pwd, string user)
        {
            try
            {
                GetAllUsers().AsQueryable().FirstOrDefault(x => x.Passkey == pwd);
                GetAllUsers().AsQueryable().FirstOrDefault(x => x.Username == user);

                UpdateUser(user);
                //UpdateUser(GetAllUsers().AsQueryable().FirstOrDefault(x => x.Username == user);
                return true;

            }
            catch (Exception ex)
            {
                GlobalSettings.ErrorMsg = ex.Message;
                return false;
            }


        }

       public enum Roles
        {
            SysAdmin,
            SalesRep,
            Accounts,
            StoreManager,
            HumanResources
        }
    }
}
