using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyManagementSystem
{
    public partial class adminDashboard : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tharindu\Documents\pharmacy.mdf;Integrated Security=True;Connect Timeout=30";


        public adminDashboard()
        {
            InitializeComponent();

            displayTotalCashier();
            displayTotalOrders();
            displayTodaysRevenue();
            displayTotalRevenue();
            displayCustomers();
            displayTotalStock();
            displayStockOuts();
        }



        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            
            displayTotalCashier();
            displayTotalOrders();
            displayTodaysRevenue();
            displayTotalRevenue();
            displayCustomers();
            displayTotalStock();
            displayStockOuts();
        }





        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }




        public void displayCustomers()
        {
            adminCustomersData acData = new adminCustomersData();

            dataGridView1.DataSource = acData.customersDataList();
        }






        public void displayTotalCashier()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT COUNT (id) as totalCashier FROM users WHERE role = 'Cashier'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalCashier"] != DBNull.Value)
                        {
                            int totalCash = (int)reader["totalCashier"];

                            totalCashier.Text = totalCash.ToString();
                        }
                        

                    }
                }
            }
        }



        public void displayTotalOrders()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT COUNT (id) as totalOrders FROM transactions";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalOrders"] != DBNull.Value)
                        {
                            int totalOrds = (int)reader["totalOrders"];

                            totalOrders.Text = totalOrds.ToString();
                        }


                    }
                }
            }
        }





        public void displayTodaysRevenue()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                DateTime today = DateTime.Today;

                string selectData = "SELECT SUM(total_price) as todaysRevenue FROM transactions WHERE date_trans = '" + today + "'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["todaysRevenue"] != DBNull.Value)
                        {
                            decimal todayRevs = Convert.ToDecimal (reader["todaysRevenue"]);

                            todayRevenue.Text = "Rs. " + todayRevs.ToString();
                        }
                    }
                }
            }
        }





        public void displayTotalRevenue()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                DateTime today = DateTime.Today;

                string selectData = "SELECT SUM(total_price) as totalRevenue FROM transactions";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalRevenue"] != DBNull.Value)
                        {
                            decimal totalRevs = Convert.ToDecimal(reader["totalRevenue"]);

                            totalRevenue.Text = "Rs. " + totalRevs.ToString();
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }





        public void displayTotalStock()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT SUM (stock) as TotalStock1 FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["TotalStock1"] != DBNull.Value)
                        {
                            int totalStk = (int)reader["TotalStock1"];

                            TotalStock.Text = totalStk.ToString();
                        }
                    }
                }
            }
        }






        public void displayStockOuts()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                

                //string selectData = "SELECT COUNT (id) as sId FROM stockNotifications";

                string selectData = "SELECT COUNT (id) as sId FROM products WHERE stock < reOrderPoint";


                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["sId"] != DBNull.Value)
                        {
                            int stkOuts = (int)reader["sId"];

                            outOfStock.Text = stkOuts.ToString();
                        }
                    }
                }
            }
        }

        private void outOfStock_Click(object sender, EventArgs e)
        {

        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
