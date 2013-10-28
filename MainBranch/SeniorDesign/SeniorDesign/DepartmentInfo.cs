using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SeniorDesign
{
    public partial class DepartmentInfo : Form
    {
        string depInfo = "..//..//..//DepartmentInfo.txt";
        public DepartmentInfo()
        {
            InitializeComponent();
            LoadInformation();
            //LoadStateComboBox();
        }
        private void LoadStateComboBox()
        {
            //List<string>stateCodeList = new List<string>();
            //using (StreamReader sr = new StreamReader("..//..//..//statecodelist.txt"))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        stateCodeList.Add(sr.ReadLine());
            //    }
            //}
            //var dataSource = new List<Language>();
            //foreach (string s in stateCodeList)
            //{
            //    dataSource.Add(new Language() {Name = s, Value = s });
            //}
            ////Setup data binding
            //this.cbState.DataSource = dataSource;
            //this.cbState.DisplayMember = "Name";
            //this.cbState.ValueMember = "Value";

            //// make it readonly
            //this.cbState.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LoadInformation()
        {
            if (File.Exists(depInfo))
            {
                using(StreamReader sr = new StreamReader(depInfo))
                {
                    string[] line = sr.ReadLine().Split(',');
                    txtName.Text = line[0];
                    txtAddress.Text = line[1];
                    txtZip.Text = line[2];
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(depInfo))
            {
                sw.Write(txtName.Text + "," + txtAddress.Text + "," + txtZip.Text);
            }
            Close();
        }

        private void searchZip(object sender, EventArgs e)
        {
            List<string> results = new List<string>();
            const string pattern = @"\d{5}";
            if (Regex.IsMatch(txtZip.Text,pattern ))
            {
                string query = "Select City, State FROM zipcode where Zip=" + txtZip.Text +";";
                results = DBConnection.Select(query);
                if (results.Count > 0)
                {
                    lblCity.Text = results[0] + "," + results[1];
                }
                else
                    lblCity.Text = "Zip code not recognized";
            }
        }

        private void close(object sender, FormClosingEventArgs e)
        {
            Close();
        }
        private void Close()
        {
            MainView mv = new MainView();
            this.Hide();
            mv.Show();
        }
    }
}
