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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            UsersModel newUser = new UsersModel().GetUser(GlobalSettings.User);
            if (newUser.Passkey == GlobalSettings.EncryptPasskey(OldPassword.Text))
            {
                newUser.Passkey = GlobalSettings.EncryptPasskey(NewPassword.Text);
                if (newUser.UpdateUser(GlobalSettings.User))
                {
                    MessageBox.Show("Password changed Successully", "Sell For Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                };

            }
            else
            {
                MessageBox.Show("Old Password is wrong!!!", "Sell For Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
