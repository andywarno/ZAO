using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SeniorDesign
{
    class DataInsert
    {
        public static void ImportData()
        {
            MySqlConnection con = DBConnection.conn;
            List<string[]> rows = new List<string[]>();
            try
            {
                
                string[] temp = {"..//../..//tableScript.sql"};
                string command = "";
                foreach (string s in temp)
                {
                    using (StreamReader sr = new StreamReader(s))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            if (line.Contains(";"))
                            {
                                MySqlCommand cmd = new MySqlCommand(line, con);
                                cmd.ExecuteNonQuery();
                                command = "";
                            }
                            else
                            {
                                command += line;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex));
            }
        }
    }
}


