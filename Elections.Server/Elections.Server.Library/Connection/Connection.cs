using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Elections.Server.Library.Connection
{
    public class Connection
    {
        public static MySqlConnection GetConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Mysql"].ConnectionString;
            var connection = new MySqlConnection(connectionString);
            return connection;
        }

        public static void OpenConnection()
        {
            try
            {
                GetConnection().Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                GetConnection().Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
