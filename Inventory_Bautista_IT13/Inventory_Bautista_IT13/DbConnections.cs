using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DatabaseProject
{
    public static class DbConnections
    {
        private static readonly string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB_Inventory_Bautista_IT13;Integrated Security=True";

        public static int ExecuteQuery(Microsoft.Data.SqlClient.SqlCommand command)
        {
            try
            {
                using (Microsoft.Data.SqlClient.SqlConnection connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
                {
                    connection.Open();
                    command.Connection = connection;
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Database error: {ex.Message}", ex);
            }
        }

        public static DataTable ExecuteReader(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (Microsoft.Data.SqlClient.SqlConnection connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
                {
                    connection.Open();
                    using (Microsoft.Data.SqlClient.SqlCommand command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                    using (Microsoft.Data.SqlClient.SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading data: {ex.Message}", ex);
            }

            return dataTable;
        }
    }
}