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
    public partial class OpenStoreForm : Form
    {
        StoreModel allStores = new StoreModel();
        public OpenStoreForm()
        {
            InitializeComponent();
        }

        private void OpenStoreForm_Load(object sender, EventArgs e)
        {
           
            //   allStores.GetAllStores().ToList();
            foreach (StoreModel store in allStores.GetAllStores())
            {
                StoresListBox.Items.Add(store.BusinessName.ToString());
            }
            
               
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (StoresListBox.SelectedItem ==null)
            {
                MessageBox.Show("No Store selected!", "Sell For Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if(GlobalSettings.StoreName != string.Empty)
                {
                    GlobalSettings.StoreName = string.Empty;
                }
               GlobalSettings.StoreName += " - "+ allStores.GetStoreByName(StoresListBox.SelectedItem.ToString()).BusinessName;
                GlobalSettings.EditStore = StoresListBox.SelectedItem.ToString();
                //MessageBox.Show(GlobalSettings.StoreName);
                this.Hide();


            }
        }
    }
}
