using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;

namespace WebApplication2.Models
{
    public class productRepository
    {
        public void add(products p)
        {
            string connectionstring = " Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=mydb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = "INSERT INTO productsnew (name, description, price) VALUES (@name, @description, @price)";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@price", p.price);

                connection.Open();
                cmd.ExecuteNonQuery();
            }


        }

        public void update(products p)
        {
            string connectionstring = " Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=mydb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = "UPDATE productsnew SET description = @description WHERE name = @name";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@description", p.description);
                

                connection.Open();
                cmd.ExecuteNonQuery();
            }


        }


        public List<products> viewproducts()
        {
            List<products> products = new List<products>();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=mydb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM productsnew";
                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Creating a new Product object for each row
                        products p = new products();


                        p.name = reader.GetString(1); // Assuming second column is Name
                        p.description = reader.GetString(2); // Assuming third column is Description
                        p.price = reader.GetString(3);

                        products.Add(p);
                    }

                      
                      
                    }

                }
            return products;


        }

    }

    }


