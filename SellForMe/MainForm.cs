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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FormMdi_Load(object sender, EventArgs e)            
        {
            //DisableControls();


            lblLogin.Text = GlobalSettings.LogState;
            lblUser.Text = GlobalSettings.User;
            if (Properties.Settings.Default.ServerName == "" || Properties.Settings.Default.Username == "" || Properties.Settings.Default.Password=="")
            {
                DataBaseConnectivity ConnectDb = new DataBaseConnectivity();
                ConnectDb.ShowDialog();
            }
            else
            {
                LoginForm NewLogin = new LoginForm();
                NewLogin.ShowDialog();
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            lblLogin.Text = GlobalSettings.LogState;
            lblUser.Text = "Welcome "+ GlobalSettings.User +"!";
            GlobalSettings storeName = new GlobalSettings();
            this.Text = storeName.GetStoreName().ToString();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            if (lblLogin.Text == "LogOut")
            {
                DialogResult dr =MessageBox.Show("Are sure you want to LogOut?", "Sell for Me 1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr== DialogResult.Yes)
                {
                GlobalSettings.User = string.Empty;
                GlobalSettings.LogState = "Log In";
                GlobalSettings.StoreName = string.Empty;
                lblUser.Text = string.Empty;
                lblLogin.Text = "Log In";
                LoginForm login = new LoginForm();              
                login.ShowDialog();
                }

            }
            else
            {
                LoginForm login = new LoginForm();
                login.ShowDialog();
            }
        }

        private void newStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStoreForm newStore = new NewStoreForm();
            newStore.ShowDialog();
        }

        private void openStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenStoreForm openStore = new OpenStoreForm();
            openStore.ShowDialog();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm newUser = new UsersForm();
            newUser.ShowDialog();
        }

        public void DisableControls()
        {
            openStoreToolStripMenuItem.Enabled = false;
            newStoreToolStripMenuItem.Enabled = false;
            closeStoreToolStripMenuItem.Enabled = false;
            changePasswordToolStripMenuItem.Enabled = false;
            manageCurrentDatabaseToolStripMenuItem.Enabled = false;


            itemsToolStripMenuItem.Enabled = false;
            salesToolStripMenuItem.Enabled = false;
            viewToolStripMenuItem.Enabled = false;
            accountsToolStripMenuItem.Enabled = false;
            reportsToolStripMenuItem.Enabled = false;
            toolsToolStripMenuItem.Enabled = false;
            helpToolStripMenuItem.Enabled = false;

            MakeSalesButton.Enabled = false;
            ViewSalesButton.Enabled = false;

        }

        public void EnableSysAdminControls()
        {
            openStoreToolStripMenuItem.Enabled = true;
            newStoreToolStripMenuItem.Enabled = true;
            closeStoreToolStripMenuItem.Enabled = true;
            changePasswordToolStripMenuItem.Enabled = true;
            manageCurrentDatabaseToolStripMenuItem.Enabled = true;


            itemsToolStripMenuItem.Enabled = true;
            salesToolStripMenuItem.Enabled = true;
            viewToolStripMenuItem.Enabled = true;
            accountsToolStripMenuItem.Enabled = true;
            reportsToolStripMenuItem.Enabled = true;
            toolsToolStripMenuItem.Enabled = true;
            helpToolStripMenuItem.Enabled = true;

            MakeSalesButton.Enabled = true;
            ViewSalesButton.Enabled = true;
        }

        public void DiableSalesRepControls()
        {
            EnableSysAdminControls();

            databaseToolStripMenuItem.Enabled = false;
            licenseManagerToolStripMenuItem.Enabled = false;


            reviewSalesToolStripMenuItem.Enabled = false;
            reviewPurchasesToolStripMenuItem.Enabled = false;

            newStoreToolStripMenuItem.Enabled = false;
            manageCurrentDatabaseToolStripMenuItem.Enabled = false;

            newItemToolStripMenuItem.Enabled = false;
            itemListToolStripMenuItem.Enabled = false;
            importItemsToolStripMenuItem.Enabled = false;

            assetsManagerToolStripMenuItem.Enabled = false;
            equityToolStripMenuItem.Enabled = false;

            profitAndLossAnalysisToolStripMenuItem.Enabled = false;
            trialBalanceToolStripMenuItem.Enabled = false;
            balanceSheetToolStripMenuItem.Enabled = false;


            salesEvaluationToolStripMenuItem.Enabled = false;
            salesDetailsToolStripMenuItem.Enabled = false;

            manageUsersToolStripMenuItem.Enabled = false;
        }

        public void DisableAccountsControls()
        {
            EnableSysAdminControls();
        }

        public void DisableStoreManagerControls()
        {
            EnableSysAdminControls();
        }

        public void DisableHumanResourcesControls()
        {
            EnableSysAdminControls();
        }
     
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockForm stock = new StockForm();
            stock.ShowDialog();
        }

        private void allItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductListForm products = new ProductListForm();
            products.ShowDialog();
        }

        private void closeStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalSettings.StoreName = string.Empty;
            GlobalSettings storeName = new GlobalSettings();
            this.Text = storeName.GetStoreName().ToString();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalSettings.LogState != string.Empty)
            {
                ChangePasswordForm changePass = new ChangePasswordForm();
                changePass.ShowDialog();
            }
        }
                private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm newUser = new UsersForm();
            newUser.ShowDialog();
        }

        private void importItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportStockForm import = new ImportStockForm();
            //import.MdiParent = MdiParent;
            //import.Show();
            import.ShowDialog();
            import.Location = new Point(30, 40);

        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBaseConnectivity openDb = new DataBaseConnectivity();
            openDb.ShowDialog();
        }

        private void editItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditItemList editItem = new EditItemList();
            editItem.ShowDialog();
        }

        private void MakeSalesButton_Click(object sender, EventArgs e)
        {
            SalesForm sales = new SalesForm();
            sales.ShowDialog();
        }

        private void manageStoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStoresForm msf = new ManageStoresForm();
            msf.ShowDialog();
        }

        private void priceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PriceListForm pricelst = new PriceListForm();
            pricelst.ShowDialog();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm sale = new SalesForm();
            sale.ShowDialog();
        }

        private void ViewSalesButton_Click(object sender, EventArgs e)
        {
            ViewSalesForm newForm = new ViewSalesForm();
            newForm.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseItem newform = new PurchaseItem();
            newform.ShowDialog();
        }
    }
}
