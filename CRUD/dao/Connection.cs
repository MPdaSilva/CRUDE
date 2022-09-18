using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Connection
    {

        private static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\banco.mdf;";

        private static SqlConnection conn = null;

        public static SqlConnection GetConnection()
        {

            if (conn == null)
            {
                conn = new SqlConnection(connString);

                try
                {
                    conn.Open();
                }
                catch (SqlException sqle)
                {
                    conn = null;
                    TextWriter erro = Console.Error;
                    erro.WriteLine("***************Depuração*******************\n", sqle.Message);
                }
            }
            return conn;
        }
        public static void closeConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}
