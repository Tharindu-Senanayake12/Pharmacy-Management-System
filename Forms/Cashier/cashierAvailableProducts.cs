using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PharmacyManagementSystem
{
    internal class cashierAvailableProducts
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tharindu\Documents\pharmacy.mdf;Integrated Security=True;Connect Timeout=30";




        public int ID { set; get; }  // 0 
        public string ProductID { set; get; }     // 1
        public string ProductName { set; get; }   // 2
        public string Category { set; get; }      // 3
        public string Price { set; get; }         // 4
        public string Stock { set; get; }        // 5
        public string ReorderPoint { set; get; }      // 9
        public string MaxStock { set; get; }          // 10



        public List<adminAddProductsData> availableProductsList()
        {
            List<adminAddProductsData> listData = new List<adminAddProductsData>();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT id, prod_id, prod_name, category, price, stock, reOrderPoint, maxStock FROM products WHERE status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        adminAddProductsData aapData = new adminAddProductsData();

                        aapData.ID = (int)reader["id"];
                        aapData.ProductID = reader["prod_id"].ToString();
                        aapData.ProductName = reader["prod_name"].ToString();
                        aapData.Category = reader["category"].ToString();
                        aapData.Price = reader["price"].ToString();
                        aapData.Stock = reader["stock"].ToString();
                        aapData.ReorderPoint = reader["reOrderPoint"].ToString();
                        aapData.MaxStock = reader["maxStock"].ToString();


                        listData.Add(aapData);


                    }
                }
            }

            return listData;
        }
    }
}
