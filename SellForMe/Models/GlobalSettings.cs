using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SellForMe.Models
{
    class GlobalSettings
    {
        //Database settings and connectivity
        public static  string ConString = "Data Source=" + Properties.Settings.Default.ServerName + ";Initial Catalog="+ Properties.Settings.Default.DatabaseName+";User ID="+ Properties.Settings.Default.Username+";Password="+Properties.Settings.Default.Password;
        
        public static string ErrMsg;
        public static SqlConnection Connection = new SqlConnection();
        public static SqlCommand Cmd = new SqlCommand();

        static string key = "Sales@App1";

        public static string LogState="Login";
        public static string User =string.Empty;

     public static List<string> Code { get; set; } = new List<string>();

        //For trapping errors if occured in an operation
        public static string ErrorMsg { get; internal set; }

        public static string StoreName { get; set; } 
        public static string EditStore { get; set; }
        
        public string GetStoreName()
        {
          return  "Sell For Me 1.0"+ StoreName;
        }
        public static bool ConnectDb()
        {
            try
            {
             if(Connection.State == ConnectionState.Open)
                {
                    Connection.Close();                    
                }
                    Connection.Open();
                    return true;
            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message;
                return false;
                throw ex;
            }
           
        }

        //Encrypting a Password

        public static string EncryptPasskey(string passkey)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(passkey);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        //Decrypting a Password
        public static string DecryptPasskey(string passkey)
        {
            byte[] data = Convert.FromBase64String(passkey);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToString(UTF8Encoding.UTF8.GetString(results));
                }
            }
        }



        //Hashing and Salting a password with SHA256

        public static string GetHashedPassword(string passkey)
        {
            //sha256 is disposable by inheritance
            using(var sha256 = SHA256.Create())
            {
                //send a sample text to hash
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(passkey + GetSalt().ToString()));
                //get the hashed string
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        
        public static string GetSalt()
        {
            byte[] bytes = new byte[128 / 8];
            using(var keyGen = RandomNumberGenerator.Create())
            {
                keyGen.GetBytes(bytes);
                return BitConverter.ToString(bytes).Replace("-", "").ToLower().ToString();
            }
        }
        //End of Hashing and Salting a password


        //Hashing a password only with HashAlgorithm
       public static string HasPassword(string password)
        {
            
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
            
        }




        public byte[] GetImageData(string FileName)
        {
            FileStream fsImageStream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            byte[] bImageData = new byte[fsImageStream.Length];
            fsImageStream.Read(bImageData, 0, Convert.ToInt32(fsImageStream.Length));
            fsImageStream.Close();
            return bImageData;
        }

       // Dim imgStream As New System.IO.MemoryStream
       //Dim imgByte As Byte() = Nothing

       //If Not IsNothing(PictureBox1.Image) Then
       //    PictureBox1.Image.Save(imgStream, Imaging.ImageFormat.Jpeg)
       //     imgByte = imgStream.GetBuffer
       // End If

            public static byte[] ImageToByteArray(Image img, PictureBox pic)
            {
            using(MemoryStream ms = new MemoryStream())
            {
                if(pic.Image != null)
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                return ms.ToArray();
            }
        }

        public static Image GetDataToImage(byte[] pData)
        {
            if(pData != null)
            {
            try
            {
                ImageConverter imgCon = new ImageConverter();
                return imgCon.ConvertFrom(pData) as Image;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                throw ex;
            }
            }
            else
            {
                return null;
            }
           
        }


        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
        public static void ColorGrid(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
                }
                else
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }



        public DataTable ReadExcel(string fileName, string sheetName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
            {
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';";
            }
            else
            {
                conn = @"provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=Yes';";
            }
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdapt = new OleDbDataAdapter("SELECT * FROM [" + sheetName + "$]", con);
                    oleAdapt.Fill(dtexcel);

                }
                catch (Exception ex)
                {
                  GlobalSettings.ErrorMsg= ex.Message.ToString();
                    return null;

                }
            }
            return dtexcel;

        }


        public static string RandomCode()
        {
            var ItemCode = string.Empty;
            Random rand = new Random();
            int number;
            for (int i = 0; i <= 4; i++)
            {
                number = rand.Next(1, 5);
                ItemCode += number.ToString();
            }

            if (Code.Contains(ItemCode))
            {
                number = rand.Next(1, 5);
                ItemCode += number.ToString();
            }
            else
            {
               Code.Add(ItemCode);
            }
            return ItemCode;

        }

        public string ItemCode = string.Empty;
        public List<string> GeneratedItemCode = new List<string>();
        public string  RandomItemCode()
        {
            ItemCode = string.Empty;
            Random rand = new Random();
            int number;
            for (int i = 0; i <= 6; i++)
            {
                number = rand.Next(1, 8);
                ItemCode += number.ToString();
            }
             if (GeneratedItemCode.Contains(ItemCode))
            {
                number = rand.Next(1, 10);                
                //MessageBox.Show(LblItemCode.Text + " already Exist!");
            }
            else
            {
                GeneratedItemCode.Add(ItemCode);
                //GenerateButto.Text = listBox1.Items.Count.ToString();
            }
            return  "ITEM-" + ItemCode;

        }



        public static string RandomGuid()
        {
            var value = Guid.NewGuid().ToString("N").Substring(0,5);
            return value;
        }
    }
}
