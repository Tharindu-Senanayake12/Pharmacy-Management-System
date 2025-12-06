using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PharmacyManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            INotification notification = new Notification();
            StockChecker stockChecker = new StockChecker(notification);
            //stockChecker.CheckStockLevels();

        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                this.Hide();
                loginForm.ShowDialog();
                
            }
        }

        private void main_inventoryBtn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = true;
            adminAddUsers1.Visible = false;
            adminAddCategories1.Visible = false;
            notifications1.Visible = false;

            AdminAddProducts aaProd = adminAddProducts1 as AdminAddProducts;


            if (aaProd != null)
            {
                aaProd.refreshData();
            }
        }

        private void adminAddProducts1_Load(object sender, EventArgs e)
        {

        }

        private void main_dashboardBtn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddProducts1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddCategories1.Visible = false;
            notifications1.Visible = false;

            adminDashboard aDashboard = adminDashboard1 as adminDashboard;


            if (aDashboard != null)
            {
                aDashboard.refreshData();
            }

        }

        private void main_usersBtn_Click(object sender, EventArgs e)
        {
            adminCustomers1.Visible = true;
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddCategories1.Visible = false;
            notifications1.Visible = false;


            adminCustomers aCust = adminCustomers1 as adminCustomers;


            if (aCust != null)
            {
                aCust.refreshData();
            }
        }

        private void main_categoriesBtn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddCategories1.Visible = true;
            notifications1.Visible = false;

            AdminAddCategories aaCat = adminAddCategories1 as AdminAddCategories;


            if (aaCat != null)
            {
                aaCat.refreshData();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            adminCustomers1.Visible = false;
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddUsers1.Visible = true;
            adminAddCategories1.Visible = false;
            notifications1.Visible = false;

            adminAddUsers aaUser1 = adminAddUsers1 as adminAddUsers;


            if (aaUser1 != null)
            {
                aaUser1.refreshData();
            }
        }


        //Notifications 
        private void main_notificationBtn_Click(object sender, EventArgs e)
        {
            adminCustomers1.Visible = false;
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddCategories1.Visible = false;
            notifications1.Visible = true;


            notifications aNotifications = notifications1 as notifications;


            if (aNotifications != null)
            {
                aNotifications.refreshData();
            }
        }

        private void adminDashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
