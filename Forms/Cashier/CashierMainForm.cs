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
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                this.Hide();
                loginForm.ShowDialog();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cashier_dashboardBtn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            cashierOrders11.Visible = false;
            adminCustomers1.Visible = false;
            notifications1.Visible = false;

            adminDashboard aDashboard = adminDashboard1 as adminDashboard;

            if (aDashboard != null)
            {
                aDashboard.refreshData();
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void cashier_CustomersBtn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            cashierOrders11.Visible = false;
            adminCustomers1.Visible = true;
            notifications1.Visible = false;

            adminCustomers aCustomers = adminCustomers1 as adminCustomers;

            if (aCustomers != null)
            {
                aCustomers.refreshData();
            }
        }

        private void cashier_PointOfSalesBtn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            cashierOrders11.Visible = true;
            adminCustomers1.Visible = false;
            notifications1.Visible = false;


            cashierOrders1 cOrders = cashierOrders11 as cashierOrders1;

            if (cOrders != null)
            {
                cOrders.refreshData();
            }
        }

        private void cashier_notificationBtn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            cashierOrders11.Visible = false;
            adminCustomers1.Visible = false;
            notifications1.Visible = true;

            
        }
    }
}
