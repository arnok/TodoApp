using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TodoApp
{
    public static class database
    {
        private static string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + @"database.mdf;Integrated Security = True";

        public static SqlConnection connection = new SqlConnection(connectionString);

        public static SqlDataReader Query(SqlCommand command)
        {
            database.connection.Close();
            try
            {
                command.Connection = database.connection;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void NonQuery(SqlCommand command)
        {
            try
            {
                command.Connection = database.connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
