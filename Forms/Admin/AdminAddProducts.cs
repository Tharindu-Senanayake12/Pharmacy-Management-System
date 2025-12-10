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
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace PharmacyManagementSystem
{
    public partial class AdminAddProducts : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tharindu\Documents\pharmacy.mdf;Integrated Security=True;Connect Timeout=30";


        public AdminAddProducts()
        {
            InitializeComponent();

            displayCategories();
            displayProducts();
        }




        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategories();
            displayProducts();
        }








        public void displayProducts()
        {
            adminAddProductsData aapData = new adminAddProductsData();
            List<adminAddProductsData> listData = aapData.addProductsList();

            dataGridView1.DataSource = listData;
        }
        




        public void displayCategories()
        {
            addProducts_category.Items.Clear();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectCategories = "SELECT * FROM categories WHERE status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(selectCategories, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        addProducts_category.Items.Add(reader["category"]);

                    }
                }
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addProducts_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png|*.jpg;*.png)";

                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;

                    addProducts_imageView.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        /*
        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (addProducts_prodID.Text == "" || addProducts_productName.Text == "" || addProducts_category.SelectedIndex == -1 
                || addProducts_price.Text == "" || addProducts_stock.Text == "" || addProducts_status.SelectedIndex == -1  || addProducts_minStock.Text == "" || addProducts_maxStock.Text == "")
            {

                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {

                    connect.Open();

                    string checkProdID = "SELECT * FROM products WHERE prod_id = @prodID";

                    using (SqlCommand checkPID = new SqlCommand(checkProdID, connect))
                    {
                        checkPID.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkPID);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(addProducts_prodID.Text.Trim() + " is taken already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                            string insertData = "INSERT INTO products (prod_id, prod_name, category, price, stock, image, status, date_insert, reOrderPoint, maxStock) " + 
                                "VALUES (@prodID, @prodName, @prodCat, @price, @stock, @image, @status, @date, @minStock, @maxStock)";



                            string relativePath = Path.Combine("products_directory", addProducts_prodID.Text.Trim() + ".jpg");
                            string path = Path.Combine(baseDirectory, relativePath);

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }


                            File.Copy(addProducts_imageView.ImageLocation ,path, true);



                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodName", addProducts_productName.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodCat", addProducts_category.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                cmd.Parameters.AddWithValue("@image", path);
                                cmd.Parameters.AddWithValue("@status", addProducts_status.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@minStock", addProducts_minStock.Text.Trim());
                                cmd.Parameters.AddWithValue("@maxStock", addProducts_maxStock.Text.Trim());

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);


                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    connect.Close();
                }
            }
            displayProducts();
        }

        */




        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addProducts_prodID.Text) ||
                string.IsNullOrWhiteSpace(addProducts_productName.Text) ||
                addProducts_category.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(addProducts_price.Text) ||
                string.IsNullOrWhiteSpace(addProducts_stock.Text) ||
                addProducts_status.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(addProducts_minStock.Text) ||
                string.IsNullOrWhiteSpace(addProducts_maxStock.Text))
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate numerical inputs
            if (!decimal.TryParse(addProducts_price.Text.Trim(), out decimal price) || price <= 0)
            {
                MessageBox.Show("Invalid price. Enter a valid positive number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(addProducts_stock.Text.Trim(), out int stock) || stock < 0)
            {
                MessageBox.Show("Invalid stock quantity. Enter a valid non-negative integer.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(addProducts_minStock.Text.Trim(), out int minStock) || minStock < 0)
            {
                MessageBox.Show("Invalid minimum stock quantity. Enter a valid non-negative integer.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(addProducts_maxStock.Text.Trim(), out int maxStock) || maxStock < minStock)
            {
                MessageBox.Show("Invalid max stock quantity. It must be greater than or equal to min stock.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string checkProdID = "SELECT COUNT(*) FROM products WHERE prod_id = @prodID";

                using (SqlCommand checkPID = new SqlCommand(checkProdID, connect))
                {
                    checkPID.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());

                    int count = (int)checkPID.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show(addProducts_prodID.Text.Trim() + " is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string relativePath = Path.Combine("products_directory", addProducts_prodID.Text.Trim() + ".jpg");
                string path = Path.Combine(baseDirectory, relativePath);
                string directoryPath = Path.GetDirectoryName(path);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                try
                {
                    File.Copy(addProducts_imageView.ImageLocation, path, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string insertData = "INSERT INTO products (prod_id, prod_name, category, price, stock, image, status, date_insert, reOrderPoint, maxStock) " +
                                    "VALUES (@prodID, @prodName, @prodCat, @price, @stock, @image, @status, @date, @minStock, @maxStock)";

                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                {
                    cmd.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                    cmd.Parameters.AddWithValue("@prodName", addProducts_productName.Text.Trim());
                    cmd.Parameters.AddWithValue("@prodCat", addProducts_category.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@image", path);
                    cmd.Parameters.AddWithValue("@status", addProducts_status.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@minStock", minStock);
                    cmd.Parameters.AddWithValue("@maxStock", maxStock);
                    cmd.Parameters.AddWithValue("@date", DateTime.Today);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Product added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
                displayProducts();
            }
        }









        public void clearFields()
        {
            addProducts_prodID.Text = "";
            addProducts_productName.Text = "";
            addProducts_category.SelectedIndex = -1;
            addProducts_price.Text = "";
            addProducts_stock.Text = "";
            addProducts_imageView.Image = null;
            addProducts_status.SelectedIndex = -1;
            addProducts_minStock.Text = "";
            addProducts_maxStock.Text = "";
        }

        private void addProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }


        private int getID = 0; 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow  row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                addProducts_prodID.Text = row.Cells[1].Value.ToString();
                addProducts_productName.Text = row.Cells[2].Value.ToString();
                addProducts_category.SelectedItem = row.Cells[3].Value.ToString();
                addProducts_price.Text = row.Cells[4].Value.ToString();
                addProducts_stock.Text = row.Cells[5].Value.ToString();
                addProducts_status.SelectedItem = row.Cells[7].Value.ToString();
                addProducts_minStock.Text = row.Cells[9].Value.ToString();
                addProducts_maxStock.Text = row.Cells[10].Value.ToString();


                string imagePath = row.Cells[6].Value.ToString();

                try
                {
                    if (imagePath != null)
                    {
                        addProducts_imageView.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        addProducts_imageView.Image = null;
                    }
                    }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (addProducts_prodID.Text == "" || addProducts_productName.Text == "" || addProducts_category.SelectedIndex == -1
                || addProducts_price.Text == "" || addProducts_stock.Text == "" || addProducts_status.SelectedIndex == -1)
            {

                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    if (MessageBox.Show("Are you sure you want to update ID : " + getID + "?", "Confirmation Message"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string updateData = "UPDATE products SET prod_id = @prodID, prod_name = @prodName, category = @category, price = @price" +
                            ", stock = @stock, status = @status, reOrderPoint = @minStock, maxStock = @maxStock WHERE id = @id";


                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@prodId", addProducts_prodID.Text.Trim());
                            cmd.Parameters.AddWithValue("@prodName", addProducts_productName.Text.Trim());
                            cmd.Parameters.AddWithValue("@category", addProducts_category.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                            cmd.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", addProducts_status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@minStock", addProducts_minStock.Text.Trim());
                            cmd.Parameters.AddWithValue("@maxStock", addProducts_maxStock.Text.Trim());

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            displayProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addProducts_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addProducts_prodID.Text == "" || addProducts_productName.Text == "" || addProducts_category.SelectedIndex == -1
                || addProducts_price.Text == "" || addProducts_stock.Text == "" || addProducts_status.SelectedIndex == -1)
            {

                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    if (MessageBox.Show("Are you sure you want to Delete ID : " + getID + "?", "Confirmation Message"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string deleteData = "DELETE FROM products WHERE id = @id";


                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            displayProducts();
        }

        private void addProducts_imageView_Click(object sender, EventArgs e)
        {

        }

        private void AdminAddProducts_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }






        ////// Search Function

        private void displayProducts(string searchQuery = "")
        {
            List<adminAddProductsData> listData;

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                adminAddProductsData aapData = new adminAddProductsData();
                listData = aapData.addProductsList();
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "SELECT * FROM products WHERE prod_name LIKE @search OR prod_id LIKE @search";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        listData = table.AsEnumerable().Select(row => new adminAddProductsData
                        {
                            ProductID = row["prod_id"].ToString(),
                            ProductName = row["prod_name"].ToString(),
                            Category = row["category"].ToString(),
                            Price = row["price"].ToString(),   // Convert decimal to string
                            Stock = row["stock"].ToString(),   // Convert int to string
                            Image = row["image"].ToString(),
                            Status = row["status"].ToString(),
                            ReorderPoint = row["reOrderPoint"].ToString(),
                            MaxStock = row["maxStock"].ToString(),
                        }).ToList();
                    }
                }
            }

            dataGridView1.DataSource = listData;
        }

        // Call this method in the search button click event

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            string searchQuery = searchTextBox.Text.Trim();
            displayProducts(searchQuery);
        }
    }
}
