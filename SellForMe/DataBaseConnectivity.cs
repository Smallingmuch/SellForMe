using SellForMe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellForMe
{
    public partial class DataBaseConnectivity : Form
    {
        public DataBaseConnectivity()
        {
            InitializeComponent();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(Password.UseSystemPasswordChar == true)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
            
        }

        private void ConnectDb_Click(object sender, EventArgs e)
        {
            lblConnectStatus.Text = "Connecting...";
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string ConnString = "Data Source=" + ServerName.Text+ ";Initial Catalog=SellForMe;User ID=" + Username.Text + ";Password=" + Password.Text;
                 SqlConnection Connection = new SqlConnection(ConnString);

                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
                Connection.Open();

                if (Connection.State == ConnectionState.Open) { 
                      
                    Properties.Settings.Default.ServerName =  ServerName.Text;
                    Properties.Settings.Default.Username = Username.Text;
                    Properties.Settings.Default.Password = Password.Text;
                    Properties.Settings.Default.Save();

                    lblConnectStatus.Text = "Connected";
                    //LoginForm NewLogin = new LoginForm();
                    //NewLogin.ShowDialog();

                    //this.Close();
                    MessageBox.Show("Database connected successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                
            }
            
            catch (Exception ex)
            {
                if (ex.Message.ToString().Contains("The server was not found or was not accessible"))
                {
                    MessageBox.Show("Please check your server name correctly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(ex.Message.ToString().Contains("login failed for user"))
                {
                    MessageBox.Show("Please check your username and passed if it's correct!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
               // throw ex;
                
            }
      
            
        }

        private void DataBaseConnectivity_Load(object sender, EventArgs e)
        {
            lblConnectStatus.Visible = true;
          if(  Properties.Settings.Default.ServerName !=null || Properties.Settings.Default.Username !=null || Properties.Settings.Default.Password != null){
                ServerName.Text = Properties.Settings.Default.ServerName;
                Username.Text = Properties.Settings.Default.Username;
                Password.Text = Properties.Settings.Default.Password;

                lblConnectStatus.Text="Connected";
            }
            else
            {
                lblConnectStatus.Text = "Not Connected!";
            }
        }
    }
}
