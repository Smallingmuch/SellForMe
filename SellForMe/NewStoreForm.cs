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
    public partial class NewStoreForm : Form
    {
        public int Id;
        public byte[] byteImg;
        public NewStoreForm()
        {
            InitializeComponent();
        }

        private void picStoreLogo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picStoreLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void CreateStoreButton_Click(object sender, EventArgs e)
            
        {
            byte ShowReg=0;
            byte AllowReprint=0;

            if (ShowRegOnInvoice.Checked)
            {
                ShowReg = 1;
            }
            if (AllowInvoiceReprint.Checked)
            {
                AllowReprint = 1;

            }


            if (picStoreLogo.Image != null)
            {
            byteImg  = GlobalSettings.ImageToByteArray(picStoreLogo.Image, picStoreLogo);
            }


            if (CreateStoreButton.Text == "CREATE")
            {
                StoreModel store = new StoreModel
                {
                    BusinessName = StoreName.Text,
                    RegNo = StoreRegNo.Text,
                    About = AboutStore.Text,
                    Address = StoreAddress.Text,
                    Email = StoreEmail.Text,
                    Phone = StorePhone.Text,
                    Logo = byteImg,
                    ShowRegNoOnInvoice = ShowReg,
                    AllowInvoiceReprint = AllowReprint,
                    Manager = StoreManager.Text   

                };
                if (store.AddStore())
                {
                    MessageBox.Show("Stored Created", "Sell For Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(GlobalSettings.ErrorMsg.ToString().ToString(), "Sell For Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                StoreModel store = new StoreModel
                {
                    BusinessName = StoreName.Text,
                    RegNo = StoreRegNo.Text,
                    About = AboutStore.Text,
                    Address = StoreAddress.Text,
                    Email = StoreEmail.Text,
                    Phone = StorePhone.Text,
                    Logo = byteImg,
                    ShowRegNoOnInvoice = ShowReg,
                    AllowInvoiceReprint = AllowReprint,
                    Manager = StoreManager.Text,
                    Id = Id

                };
                if (store.UpDateStore())
                {
                    MessageBox.Show("Store Info. Updated", "Sell For Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(GlobalSettings.ErrorMsg.ToString(), "Sell For Me 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void NewStoreForm_Load(object sender, EventArgs e)
        {
            if(GlobalSettings.EditStore != string.Empty)
            {
                StoreModel storeInfo = new StoreModel().GetStoreByName(GlobalSettings.EditStore);
                Id = storeInfo.Id;
                StoreName.Text = storeInfo.BusinessName;
                StoreAddress.Text = storeInfo.Address;
                StoreManager.Text = storeInfo.Manager;
                StoreRegNo.Text = storeInfo.RegNo;
                StorePhone.Text = storeInfo.Phone;
                StoreEmail.Text = storeInfo.Email;
                AboutStore.Text = storeInfo.About;
                ShowRegOnInvoice.Checked = Convert.ToBoolean(storeInfo.ShowRegNoOnInvoice);
                AllowInvoiceReprint.Checked = Convert.ToBoolean(storeInfo.AllowInvoiceReprint);
                picStoreLogo.Image = GlobalSettings.GetDataToImage(storeInfo.Logo);

                CreateStoreButton.Text = "UPDATE";               

            }
            GlobalSettings.EditStore = string.Empty;
            //StoreModel LoadStore = new StoreModel().GetStoreByName("G-Makeover");

            //StoreName.Text = LoadStore.BusinessName;
            //StorePhone.Text = LoadStore.Phone;
            //picStoreLogo.Image = GlobalSettings.GetDataToImage(LoadStore.Logo);
            //ShowRegOnInvoice.Checked = Convert.ToBoolean(LoadStore.ShowRegNoOnInvoice);


        }
    }
}
