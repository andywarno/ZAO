          
/* ***************************************
 * Program Created by Zack Sharkey
 * Used Dr Kaminski's Code as reference 
 * 4/23/2013
 ******************************************/
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;                   
using MySql.Data;                         
using MySql.Data.MySqlClient;    
namespace ServerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            _ConnectToDB();
        }
        private static void _ConnectToDB()
        {
            Log log = new Log();
            string password = "Xochilt8";          // COULD ASK USER FOR THIS INSTEAD
            string connStr = "server=localhost;user=root;database=crimereport;" +
                             "port=3306;password=" + password + ";";
            MySqlConnection conn;
            log.WriteLine("Connecting to MySQL...");

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                log.WriteLine(string.Format("OK, the DB Connection is {0}\n",conn.State.ToString()));
                DataRetrieval.DoQueryAllFromTable(conn, log);
                conn.Close();                
                Console.WriteLine("See WorldLoglog.txt in top-level project folder");
            }
            catch (Exception ex)
            {
                log.WriteLine("\r\nERROR, DB Connection didn't work - no trans done");
                log.WriteLine(ex.ToString());
            }
            log.WriteLine("\r\nEXITING PROGRAM");
            log.Close();

        }
       
    }
}
