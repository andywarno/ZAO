using System;
using System.IO;
using System.Data;                         
using MySql.Data;                         
using MySql.Data.MySqlClient;           

namespace ServerTest
{
    class Display
    {
        public static void PrettyPrint(MySqlDataReader rdr, Log log)
        {
            while (rdr.Read() != false)
            {
                log.WriteLine(string.Format("{0} {1} {2, 3} {3, 5} {4, 40} {5, 10} {6, 20} {7, 14} {8, 9} {9, 6} {10, 17} {11, 5} {12, 10} {13, 70} {14, 10} {15, 14} {16,16 } {17, 11} {18, 17} {19} {20} {21} {22} {23} {24} {25} {26} {27} {28} {29} {30} ",
                              rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9],
                              rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15], rdr[16], rdr[17], rdr[18], rdr[19],
                              rdr[20], rdr[21], rdr[22], rdr[23], rdr[24], rdr[25], rdr[26], rdr[27], rdr[28], rdr[29],
                              rdr[30]));
                rdr.Read();
                log.WriteLine("\n");
            }

            rdr.Close();
        }
    }
}
