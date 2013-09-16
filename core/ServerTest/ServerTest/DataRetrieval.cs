using System;
using System.IO;

using System.Data;                          
using MySql.Data;                           
using MySql.Data.MySqlClient;               

namespace ServerTest
{
    class DataRetrieval
    {
        public static void DoQueryAllFromTable(MySqlConnection conn, Log log)
        {
            try
            {
                string sql = "SELECT * FROM reports;";
                log.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                Display.PrettyPrint(rdr, log);
            }
            catch (Exception ex)
            {
                log.WriteLine(ex.ToString());
            }
        }
    }
}
