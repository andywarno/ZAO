using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ServerTest
{
    class Log
    {
        static StreamWriter output;
        public Log()
        {
            output = new StreamWriter("..\\..\\Log.txt", false);
        }
        public void WriteLine(string s)
        {
            output.WriteLine(s);
        }
        public void Close()
        {
            output.Close();
        }
    }
}
