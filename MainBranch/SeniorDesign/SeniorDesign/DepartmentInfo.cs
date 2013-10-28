using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SeniorDesign
{
    public partial class DepartmentInfo : Form
    {
        string depInfo = "..//DepartmentInfo.txt";
        public DepartmentInfo()
        {
            InitializeComponent();
            LoadStateComboBox();
            LoadInformation();
        }
        private void LoadStateComboBox()
        {
            List<string>stateCodeList = new List<string>();
            using (StreamReader sr = new StreamReader("..//..//..//statecodelist.txt"))
            {
                while (!sr.EndOfStream)
                {
                    stateCodeList.Add(sr.ReadLine());
                }
            }
            var dataSource = new List<Language>();
            foreach (string s in stateCodeList)
            {
                dataSource.Add(new Language() {Name = s, Value = s });
            }
            //Setup data binding
            this.cbState.DataSource = dataSource;
            this.cbState.DisplayMember = "Name";
            this.cbState.ValueMember = "Value";

            // make it readonly
            this.cbState.DropDownStyle = ComboBoxStyle.DropDownList;
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
                    txtCity.Text = line[2];
                    txtZip.Text = line[3];
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(depInfo))
            {
                sw.Write(txtName.Text + "," + txtAddress.Text + "," + txtCity.Text + "," + cbState.SelectedText + "," + txtZip.Text);
            }
        }
    }
}
