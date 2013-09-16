using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;  
namespace SeniorDesign
{
    class DBConnection
    {
        Log log;

        string user, pass;
        public static MySqlConnection conn;
        public DBConnection(string user, string pass)
        {
            log = new Log();
            this.user = user;
            this.pass = pass;
        }
        public bool _ConnectToDB()
        {
            bool connection = true;
            string connStr = "server=localhost;user=" + user + ";database=crimereport;" +
                             "port=3306;password=" + pass + ";";
            
            log.WriteLine("Connecting to MySQL...");

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                //log.WriteLine(string.Format("OK, the DB Connection is {0}\n", conn.State.ToString()));
                
                Console.WriteLine("See WorldLoglog.txt in top-level project folder");

            }
            catch (Exception ex)
            {
                log.WriteLine("\r\nERROR, DB Connection didn't work - no trans done");
                log.WriteLine(ex.ToString());
                connection = false;
            }
            log.WriteLine("\r\nEXITING PROGRAM");
            log.Close();
            return connection;

        }
        public static void CloseDBConnection()
        {
            conn.Close();
        }
    }
}
