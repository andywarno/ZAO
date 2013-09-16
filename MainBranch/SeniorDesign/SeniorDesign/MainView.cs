using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeniorDesign
{
    public partial class MainView : Form
    {
        public static List<string[]> rows;
        public MainView()
        {
            InitializeComponent();
            rows = new List<string[]>();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            
        }

        private void btnQueryAll_Click(object sender, EventArgs e)
        {
            rows = DataRetrieval.DoQueryAllFromTable();
            string temp = "";
            foreach(string[] sAr in rows)
            {
                foreach (string s in sAr)
                {
                    temp += string.Format(s);
                }
                temp += string.Format("\n");
                txtQueryResult.Text = temp;
            }
            
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBConnection.CloseDBConnection();
        }
    }
}
