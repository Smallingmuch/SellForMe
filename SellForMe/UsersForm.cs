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
    public partial class UsersForm : Form
    {
             
        List<string> Roles = new List<string>();
        public UsersForm()
        {
            InitializeComponent();
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            if (ConfirmPasswordTexbox.Text != PasswordTextbox.Text)
            {
                MessageBox.Show("Wrong Password Confirmation", "Sell for Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (chkSysAdmin.Checked)
            {
                Roles.Add(UsersModel.Roles.SysAdmin.ToString());
            }
            if (chkSalesRep.Checked)
            {
                Roles.Add(UsersModel.Roles.SalesRep.ToString());
            }
            if (chkAccounts.Checked)
            {
                Roles.Add(UsersModel.Roles.StoreManager.ToString());
            }
            if (chkStoreManager.Checked)
            {
                Roles.Add(UsersModel.Roles.Accounts.ToString());
            }
            if (chkHumanResourceManager.Checked)
            {
                Roles.Add(UsersModel.Roles.HumanResources.ToString());
            }

            string AssignedRoles = "";
            foreach (string item in Roles)
            {
                if (AssignedRoles != string.Empty)
                {
                    AssignedRoles += ", " + item;
                }
                else
                {
                    AssignedRoles += item;
                }
            }
       
            UsersModel NewUser = new UsersModel
            {
                Username = UsernameTextbox.Text.Trim(),
                Fullname = FullnameTextbox.Text,
                Passkey = PasswordTextbox.Text,
                Role = AssignedRoles.ToString()            
            };
            if(CreateUserButton.Text=="UPDATE USER")
            {
                if (NewUser.UpdateUser(UsernameTextbox.Text))
                {
                    MessageBox.Show("Updated Successfully", "Sell For Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(NewUser.CreateUser().ToString(), "Sell For Me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if(CreateUserButton.Text=="CREATE USER")
            {
            if (NewUser.CreateUser())
            {
                MessageBox.Show("Saved", "Sell For Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(NewUser.CreateUser().ToString(), "Sell For Me", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
            
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            DgvUsers.RowTemplate.Height = 32;
            ////allUser.GetAllUsers().ToList();
            //foreach(UsersModel user in allUser.GetAllUsers())
            //{
            //    DgvUsers.Rows.Add(user.Username, user.Fullname, user.Role);
            //    //DgvUsers.Rows[0] = user.Username;
            //    //DgvUsers.Rows[0] = user.Username;
            //}
            //UsersModel Newuse = new UsersModel().GetUser("AdamG");
            //UsernameTextbox.Text = Newuse.Username;
            //FullnameTextbox.Text = Newuse.Fullname;
            //PasswordTextbox.Text = GlobalSettings.DecryptPasskey(Newuse.Passkey);


            //if (Newuse.Role.ToString().Contains(UsersModel.Roles.Accounts.ToString()))
            //{
            //    chkAccounts.Checked = true;
            //}
            //if (Newuse.Role.ToString().Contains(UsersModel.Roles.SysAdmin.ToString()))
            //{
            //    chkSysAdmin.Checked = true;
            //}
            //if (Newuse.Role.ToString().Contains(UsersModel.Roles.HumanResources.ToString()))
            //{
            //    chkHumanResourceManager.Checked = true;
            //}
            //if (Newuse.Role.ToString().Contains(UsersModel.Roles.StoreManager.ToString()))
            //{
            //    chkStoreManager.Checked = true;
            //}
            //if (Newuse.Role.ToString().Contains(UsersModel.Roles.SalesRep.ToString()))
            //{
            //    chkSalesRep.Checked = true;
            //}

            //ConfirmPasswordTexbox.Text = PasswordTextbox.Text;
            //CreateUserButton.Text = "UPDATE USER";
        }

        
        private void UsersForm_Activated(object sender, EventArgs e)
        {
            UsersModel AllUser = new UsersModel();
            DgvUsers.Rows.Clear();
           
            foreach (UsersModel user in AllUser.GetAllUsers())
            {
                DgvUsers.Rows.Add(user.Username, user.Fullname, user.Role);
            }          
            GlobalSettings.ColorGrid(DgvUsers);
        }

        private void ConfirmPasswordTexbox_Leave(object sender, EventArgs e)
        {
            if(ConfirmPasswordTexbox.Text != PasswordTextbox.Text)
            {
                MessageBox.Show("Wrong Password Confirmation", "Sell for Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                PasswordTextbox.UseSystemPasswordChar = false;
                ConfirmPasswordTexbox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextbox.UseSystemPasswordChar = true;
                ConfirmPasswordTexbox.UseSystemPasswordChar = true;
            }
        }
    }
}
