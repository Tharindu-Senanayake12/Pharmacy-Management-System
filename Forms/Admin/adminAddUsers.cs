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
    public partial class adminAddUsers : UserControl
    {

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tharindu\Documents\pharmacy.mdf;Integrated Security=True;Connect Timeout=30";

        public adminAddUsers()
        {
            InitializeComponent();

            displayAddUsers();
        }




        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAddUsers();
        }




        public void displayAddUsers()
        {
            adminAddUsersData aauData = new adminAddUsersData();
            List<adminAddUsersData> listData = aauData.listAddUsersData();

            users_dataGridView1.DataSource = listData;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminAddUsers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1 
                || addUsers_Status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();


                    String checkUserName = "SELECT * FROM users WHERE username= @usern";
                    using (SqlCommand checkUsern = new SqlCommand(checkUserName, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            string tempUsern = addUsers_username.Text.Substring(0, 1).ToUpper() + addUsers_username.Text.Substring(1);
                            MessageBox.Show(tempUsern + " is already existing!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username, password, role, status, date_registered) VALUES (@usern, @pass, @role, @status, @date)";
                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@status", addUsers_Status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);

                            
                                cmd.ExecuteNonQuery();

                                clearField();

                                MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                
                            }
                        }
                    }
                }
            }
            displayAddUsers();

        }


        public void clearField()
        {
            addUsers_username.Text = "";
            addUsers_password.Text = "";
            addUsers_role.SelectedIndex = -1;
            addUsers_Status.SelectedIndex = -1; 
        }

        private void users_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUser_Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearField();
        }


        private int getID = 0;

        private void users_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = users_dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                addUsers_username.Text = row.Cells[1].Value.ToString();
                addUsers_password.Text = row.Cells[2].Value.ToString();
                addUsers_role.SelectedItem = row.Cells[3].Value.ToString();
                addUsers_Status.SelectedItem = row.Cells[4].Value.ToString();
            }
        }

        private void addUsers_updateBtn_Click(object sender, EventArgs e)
        {

        }





        private void addUsers_deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void addUsers_updateBtn_Click_1(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1
                || addUsers_Status.SelectedIndex == -1)
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


                        String updateData = "UPDATE users SET username = @usern , password = @pass, role = @role, status = @status WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@status", addUsers_Status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearField();

                            MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }

                    }
                }
            }
            displayAddUsers();

        }

        private void addUsers_deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1
                || addUsers_Status.SelectedIndex == -1)
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


                        String updateData = "DELETE FROM users WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearField();

                            MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }

                    }
                }
            }
            displayAddUsers();
        }
    }
}
