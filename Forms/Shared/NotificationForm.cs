using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class notifications : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tharindu\Documents\pharmacy.mdf;Integrated Security=True;Connect Timeout=30";

        public notifications()
        {
            InitializeComponent();

            LoadNotifications();


        }



        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            LoadNotifications();
        }




        /*

        private void LoadNotifications()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT id, prod_id, prod_name, stock, reOrderPoint, maxStock, notificationMessage, dateNotified FROM stockNotifications ORDER BY dateNotified DESC";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    

                    dataGridView1.DataSource = dt; // Load data into DataGridView
                }
            }
        }

        */



        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            INotification notification = new Notification();
            StockChecker stockChecker = new StockChecker(notification);
            stockChecker.CheckStockLevels();
            LoadNotifications();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void LoadNotifications()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Load all stock notifications into dataGridView1
                string query1 = "SELECT id, prod_id, prod_name, stock, reOrderPoint, maxStock, notificationMessage, dateNotified FROM stockNotifications ORDER BY dateNotified DESC";
                using (SqlDataAdapter adapter1 = new SqlDataAdapter(query1, conn))
                {
                    DataTable dt1 = new DataTable();
                    adapter1.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }

                // Load filtered data where reOrderPoint > stock into dataGridView2
                string query2 = "SELECT id, prod_id, prod_name, stock, reOrderPoint, maxStock FROM stockNotifications WHERE reOrderPoint > stock";
                using (SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn))
                {
                    DataTable dt2 = new DataTable();
                    adapter2.Fill(dt2);
                    dataGridView2.DataSource = dt2;
                }
            }
        }



    }
}
