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
    public partial class adminCustomers : UserControl
    {
        public adminCustomers()
        {
            InitializeComponent();
            displayCustomers();
        }



        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomers();
        }



        public void displayCustomers()
        {
            adminCustomersData acData = new adminCustomersData();
            dataGridView1.DataSource = acData.customersDataList();
        }
    }
}
