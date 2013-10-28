using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;  
namespace SeniorDesign
{
    class DBConnection
    {
        private static MySqlConnection connection;
        private static string uid;
        private static string password;

        private static void Initialize()
        {
            uid = "root";
            password = "Xochilt8";
            string connectionString;
            connectionString = "server=localhost;user=" + uid + ";database=crimereport;" +
                             "port=3306;password=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private static bool OpenConnection()
        {
            Initialize();
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void Insert(string query)
        {
            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        public static bool CompaintNumberCheck(string num)
        {
            string query = "SELECT * FROM reports WHERE ComplaintNum='" + num + "'";
            List<string> temp = Select(query);
            if (temp.Count == 0)
                return true;
            else
                return false;
        }
        public static List<string> Select(string query)
        {
            List<string> input = new List<string>();
            MySqlDataReader myReader = null;
            if (OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    input.Add(myReader.GetString(0));
                }
                CloseConnection();
            }
            return input;
        }

        public static MySqlDataReader SelectAll(string query)
        {
            MySqlDataReader myReader = null;
            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    myReader = cmd.ExecuteReader();
                    //CloseConnection();
                }
                catch (Exception)
                {

                }
            }
            return myReader;
        }

        public static void Update(string query)
        {
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Delete statement
        public static void Delete(string query)
        {
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
