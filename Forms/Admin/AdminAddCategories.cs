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
    public partial class AdminAddCategories : UserControl
    {

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tharindu\Documents\pharmacy.mdf;Integrated Security=True;Connect Timeout=30";


        public AdminAddCategories()
        {
            InitializeComponent();
            displayCategoriesData();
        }



        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategoriesData();
        }




        public void displayCategoriesData()
        {
            adminAddCategoriesData aacData = new adminAddCategoriesData();
            List<adminAddCategoriesData> listData = aacData.listAddCategoriesData();

            addCategories_dataGridView1.DataSource = listData;
        }




        private void addCategories_addBtn_Click(object sender, EventArgs e)
        {
            if(addCategories_catergory.Text == "" || addCategories_Status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    String insertCategory = "INSERT INTO categories (category, status, date_insert) VALUES (@category, @status, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertCategory, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", addCategories_catergory.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", addCategories_Status.SelectedItem.ToString());

                        DateTime today= DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);


                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            displayCategoriesData();
        }



        private void clearFields()
        {
            addCategories_catergory.Text = "";
            addCategories_Status.SelectedIndex = -1;
        }

        private void addCategories_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addCategories_updateBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_catergory.Text == ""  || addCategories_Status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();


                        String updateData = "UPDATE categories SET category = @category , status = @status WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@category", addCategories_catergory.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", addCategories_Status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }

                    }
                }
            }
            displayCategoriesData();
        }


        private int getID = 0;


        private void addCategories_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = addCategories_dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);

                addCategories_catergory.Text = row.Cells[1].Value.ToString();
                addCategories_Status.Text = row.Cells[2].Value.ToString();
            }
        }

        private void addCategories_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_catergory.Text == "" || addCategories_Status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();


                        String updateData = "DELETE FROM categories WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }

                    }
                }
            }
            displayCategoriesData();
        }

        private void addCategories_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
