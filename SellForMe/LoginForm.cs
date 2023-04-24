using SellForMe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellForMe
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text==string.Empty || PasswordTextbox.Text == string.Empty)
            {
                MessageBox.Show("Enter Login Detials!", "Sell for Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsernameTextbox.Focus();
                return;
            }
            UsersModel login = new UsersModel().GetUser(UsernameTextbox.Text);
            if (login == null)
            {
                MessageBox.Show("User Does not Exist!", "Sell for Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (login.Username == UsernameTextbox.Text)
            {
                if(login.Passkey == GlobalSettings.EncryptPasskey(PasswordTextbox.Text))
                {
                    GlobalSettings.LogState = "LogOut";
                    GlobalSettings.User = login.Username;

                    this.Hide();

                    OpenStoreForm openStore = new OpenStoreForm();
                    openStore.ShowDialog();
                   // MessageBox.Show("Loged In!!!");   

                }
                else
                {
                    MessageBox.Show("Wrong Password", "Sell for Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Wrong Username", "Sell for Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked){
                PasswordTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextbox.UseSystemPasswordChar = true;
            }
        }
    }
}
