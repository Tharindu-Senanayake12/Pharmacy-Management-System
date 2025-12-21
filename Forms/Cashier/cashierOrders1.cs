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
using System.Drawing.Printing;

namespace PharmacyManagementSystem
{
    public partial class cashierOrders1 : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tharindu\Documents\pharmacy.mdf;Integrated Security=True;Connect Timeout=30";



        public cashierOrders1()
        {
            InitializeComponent();

            displayCategories();
            displayAvailableProducts();
            displayAllOrders();
            displayTotal();
        }



        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategories();
            displayAvailableProducts();
            displayAllOrders();
            displayTotal();
        }







        public void displayAvailableProducts()
        {
            //adminAddProductsData prodData = new adminAddProductsData();
            //dataGridView1.DataSource = prodData.addProductsList();

            cashierAvailableProducts prodData = new cashierAvailableProducts();
            dataGridView1.DataSource = prodData.availableProductsList();
        }




        public void displayAllOrders()
        {
            cashierOrdersData coData = new cashierOrdersData();
            dataGridView2.DataSource = coData.cashierOrdersList();
        }






        public void displayCategories()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                orders_Category.Items.Clear();
                //id, prod_id, prod_name, category, price, stock

                string selectData = "SELECT * FROM categories WHERE status = 'Active'";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                            // Change
                        orders_Category.Items.Add(reader["category"].ToString());
                    }

                }
            }
        }





        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cashierOrders1_Load(object sender, EventArgs e)
        {

        }

        private void orders_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            orders_ProdName.Text = "";
            orders_ProdID.SelectedIndex = -1;
            orders_ProdID.Items.Clear();
            orders_regPrice.Text = "";
            orders_Quantity.Value = 0;

            String  selectedValue = orders_Category.SelectedItem as String;

            if (selectedValue != null)
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string selectData = $"Select * FROM products WHERE category = @category AND status = 'Active'";

                    using (SqlCommand cmd = new SqlCommand (selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", selectedValue);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string value = reader["prod_id"].ToString();

                                orders_ProdID.Items.Add(value);
                            }
                        }
                    }
                }
            }
        }

        private void orders_ProdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = orders_ProdID.SelectedItem as string;

            if(selectedValue != null)
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products WHERE prod_id = @prodID AND status = 'Active'";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@prodID", selectedValue);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string prodName = reader["prod_name"].ToString();      // Update error   3.40
                                string prodPrice = reader["price"].ToString();

                                orders_ProdName.Text = prodName;
                                orders_regPrice.Text = prodPrice;
                            }
                        }
                    }
                }
            }
        }

        private void orders_addBtn_Click(object sender, EventArgs e)
        {
            if(orders_Category.SelectedIndex == -1 || orders_ProdID.SelectedIndex == -1 || orders_ProdName.Text =="" 
                || orders_regPrice.Text == "" || orders_Quantity.Value == 0)
            {
                MessageBox.Show("Empty Fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string insertData = "INSERT INTO orders (customer_id, prod_id, prod_name, category, regular_price, quantity, status, date_ordered)" +
                        "  VALUES (@cid, @pID, @prodName, @cat, @regPrice, @qty, @status, @date) ";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cid", generateID());
                        cmd.Parameters.AddWithValue("@pID", orders_ProdID.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@prodName", orders_ProdName.Text.Trim());
                        cmd.Parameters.AddWithValue("@cat", orders_Category.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@regPrice", orders_regPrice.Text.Trim());
                        cmd.Parameters.AddWithValue("@qty", orders_Quantity.Value);
                        cmd.Parameters.AddWithValue("@status", "Pending");
                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            clearFields();
            displayTotal();
            displayAllOrders();
        }




        public int generateID()
        {
            int getID = 0;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT MAX(id) as getID FROM transactions";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["getID"] != DBNull.Value)
                            {
                                  getID = Convert.ToInt32(reader["getID"]);
                            }


                            if (getID == 0)
                            {
                                getID = 1;
                            }
                        }
                    }
                }
            }


            if (getID == 0)
            {
                return 1;
            }
            else
            {
                return getID += 1;
            }
        }



        public void clearFields()
        {
            orders_Category.SelectedIndex = -1;
            orders_ProdID.SelectedIndex = -1;
            orders_Quantity.Value = 0;
            orders_ProdName.Text = "#";
            orders_regPrice.Text = "#";
        }



        public void displayTotal()
        {
            orders_totalPrice.Text = getTotal().ToString() + ".00";
        }






        public float getTotal()
        {
            float totalPrice = 0;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT regular_price as price, quantity as qty FROM orders WHERE customer_id = " + generateID();

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("price")) && !reader.IsDBNull(reader.GetOrdinal("qty")))
                            {
                                float price;
                                int qty;
                                if (float.TryParse(reader["price"].ToString(), out price) 
                                    && int.TryParse(reader["qty"].ToString(), out qty))
                                {
                                    totalPrice += price * qty;
                                }
                            }
                        }
                    }
                }

            }
            return totalPrice;
        }




        private void orders_ClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void orders_totalPrice_Click(object sender, EventArgs e)
        {

        }

        private void orders_Amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(orders_Amount.Text);
                    float getChange = (getAmount - getTotal());

                    if (getChange <= -1)
                    {
                        orders_Amount.Text = "";
                        orders_Change.Text = "";
                    }
                    else
                    {
                        orders_Change.Text = getChange.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    orders_Amount.Text = "";
                    orders_Change.Text = "";
                }
            }
        }

        private void orders_PayBtn_Click(object sender, EventArgs e)
        {
            if (orders_Amount.Text == "" || dataGridView2.Rows.Count <=0)
            {
                MessageBox.Show("Empty Order!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Confirm Order?", "Confirmation Message", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        int customerId = generateID();

                        string insertData = "INSERT INTO transactions (customer_id, total_price, status, date_trans)" + 
                            "VALUES (@cid, @totalP, @status, @date)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cid", customerId);
                            cmd.Parameters.AddWithValue("@totalP", getTotal());
                            cmd.Parameters.AddWithValue("@status", "Completed");

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date", today);


                            cmd.ExecuteNonQuery();
                        }

                        string updateData = "UPDATE orders SET status = 'Completed' WHERE customer_id = " + (generateID() - 1 );


                        using (SqlCommand updateD = new SqlCommand(updateData, connect))
                        {
                            updateD.ExecuteNonQuery();
                        }


                        string clearData = "DELETE FROM orders";

                        using (SqlCommand clearD = new SqlCommand(clearData, connect))
                        {
                            clearD.ExecuteNonQuery();
                        }

                        MessageBox.Show("Payment Completed!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            displayAllOrders();
            displayTotal();
        }





        private void orders_removeBtn_Click(object sender, EventArgs e)
        {
            if(getOrderID != 0)
            {
                if (MessageBox.Show("Are you sure you want to Delete ID : " + getOrderID + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM orders WHERE id = " + getOrderID;

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.ExecuteNonQuery();


                            MessageBox.Show("Removed Successfully!", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }                  
            }
            else
            {
                MessageBox.Show("Select an item first!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayAllOrders();
            displayTotal();
        }



        private int getOrderID = 0;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                getOrderID = (int)row.Cells[0].Value;
            }
        }

        private void orders_recieptBtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }


        private int rowIndex = 0;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float totalPrice = getTotal();

            float y = 0;
            int count = 0;
            int colWidth = 115;
            int headerMargin = 10;
            int tableMargin = 10;

            // *************************  Font Sizes    ***************************

            Font font = new Font("Arial", 10);
            Font bold = new Font("Arial", 11, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);


            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            String headerText = "MediTrust Pharmacy System\n\n";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left
                + (dataGridView2.Columns.Count / 2) * colWidth, y, alignCenter);


            count++;
            y += tableMargin;

            string[] header = { "ID", "CID", "ProdID", "ProdName", "Category", "Qty", "RegPrice" };


            for (int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;

                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
            }


            count++;

            float rSpace = e.MarginBounds.Bottom - y;


            while (rowIndex < dataGridView2.Rows.Count)
            {
                DataGridViewRow row = dataGridView2.Rows[rowIndex];

                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    object cellValue = row.Cells[i].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;

                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }


                int labelMargin = (int)Math.Min(rSpace, 200);

                DateTime today = DateTime.Now;

                float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("-----------------------", labelFont).Width;


                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString("Total Price : \t Rs. " + totalPrice + "\n" +
                    "Amount : \t Rs. " + orders_Amount.Text + "\n\t\t-----------\n" +
                    "Change : \t Rs. " + orders_Change.Text, labelFont, Brushes.Black, labelX, y);


                labelMargin = (int)Math.Min(rSpace, -40);

                string labelText = today.ToString();
                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right 
                    - e.Graphics.MeasureString("-----------------------", labelFont).Width, y);

            }

        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
