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
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tharindu\Documents\pharmacy.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_ShowPass.Checked ? '\0' : '•';
        }

        private void login_registerBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerForm regForm = new registerForm();
            regForm.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectData = "SELECT * FROM users WHERE (username = @usern AND password = @pass) AND status = 'Active'";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);


                        if(table.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DataRow row = table.Rows[0];
                            string role = row["role"].ToString();


                            if (role == "Admin")
                            {
                                MainForm mForm = new MainForm();
                                mForm.Show();
                            }
                            else if (role == "Cashier")
                            {
                                CashierMainForm cmForm = new CashierMainForm();
                                cmForm.Show();
                            }
                            
                            this.Hide();

                        }

                        else
                        {
                            MessageBox.Show("Incorrect Username/ Password or you need Admin's approval.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }
    }
}
