using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;  
namespace SeniorDesign
{
    class DataRetrieval
    {
        public static List<string[]> DoQueryAllFromTable()
        {
            MySqlConnection con = DBConnection.conn;
            List<string[]> rows = new List<string[]>();
            try
            {
                string sql = "SELECT * FROM reports;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int fields = rdr.FieldCount;
                string[] temp = new string[fields];
                while (rdr.Read() != false)
                {
                    for (int i = 0; i < fields; i++)
                    {
                        temp[i] = rdr[i].ToString();
                    }
                    rows.Add(temp);
                }
            }
            catch (Exception ex)
            {
                
            }
            return rows;

        }
    }
}
