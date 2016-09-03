using System;
using System.Configuration;
using System.Windows.Forms;
using Elections.Server.Library.Repository;
using MySql.Data.MySqlClient;

namespace Elections.Server.Library.Connection
{
    public class Setup
    {
        public MySqlConnection OConnection { get; set; } 
        public Setup()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Mysql"].ConnectionString;
            OConnection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                OConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                OConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LoadTables()
        {
            OpenConnection();

            DataBase dataBase = DataBase.Init(OConnection, 20);
            dataBase.AllStudents = dataBase.Students.All();
            dataBase.AllGrades = dataBase.Grades.All();
            dataBase.AllSections = dataBase.Sections.All();
            dataBase.AllSexes = dataBase.Sexes.All();
            //Hello
            CloseConnection();
        }
    }
}
