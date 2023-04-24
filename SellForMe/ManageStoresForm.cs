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
    public partial class ManageStoresForm : Form
    {
        public ManageStoresForm()
        {
            InitializeComponent();
        }

        private void ManageStoresForm_Load(object sender, EventArgs e)
        {
            StoreModel allStores = new StoreModel();
            StoresLst.Items.Clear();
            foreach (StoreModel store in allStores.GetAllStores())
            {
                StoresLst.Items.Add(store.BusinessName);
                StoresLst.ValueMember = Convert.ToString(store.Id);
            }
        }

        private void StoresLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(StoresLst.SelectedValue.ToString());
        }

        private void EditStoreButton_Click(object sender, EventArgs e)
        {
            GlobalSettings.EditStore = StoresLst.SelectedItem.ToString();
            NewStoreForm EditStore = new NewStoreForm();
            EditStore.ShowDialog();
        }
    }
}
