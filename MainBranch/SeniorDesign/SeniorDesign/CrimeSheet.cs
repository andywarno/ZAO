using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SeniorDesign
{
    public partial class CrimeSheet : Form
    {
        MainView mv;
        public CrimeSheet(MainView mv)
        {
            this.mv = mv;
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CrimeSheet_Load(object sender, EventArgs e)
        {
            ShowPanel(0);
            LoadDetectiveAssists();
            LoadCrimeTypes();
        }
        private void LoadCrimeTypes()
        {
            var dataSource = new List<Language>();
            dataSource.Add(new Language() { Name = "None", Value = "none" });
            dataSource.Add(new Language() {Name = "Arson", Value = "Arson" });
            dataSource.Add(new Language() { Name = "Auto Theft", Value = "Auto Theft" });
            dataSource.Add(new Language() { Name = "B&E", Value = "BE" });
            dataSource.Add(new Language() { Name = "Counterfeiting", Value = "Counterfeiting" });
            dataSource.Add(new Language() { Name = "CSC Adult", Value = "Csc Adult" });
            dataSource.Add(new Language() { Name = "CSC Child", Value = "Csc Child" });
            dataSource.Add(new Language() { Name = "Drug Crimes", Value = "Drug Crimes" });
            dataSource.Add(new Language() { Name = "Embezzlement", Value = "Embezzlement" });
            dataSource.Add(new Language() { Name = "Felony Assault", Value = "Felony Assault" });
            dataSource.Add(new Language() { Name = "Fraud", Value = "Fraud" });
            dataSource.Add(new Language() { Name = "Home Invasion", Value = "Home Invasion" });
            dataSource.Add(new Language() { Name = "Larceny from Auto", Value = "Larceny from Auto" });
            dataSource.Add(new Language() { Name = "Metal/Scrap Theft", Value = "MetalScrap Theft" });
            dataSource.Add(new Language() { Name = "Missing Person", Value = "Missing Person" });
            dataSource.Add(new Language() { Name = "OAA", Value = "OAA" });
            dataSource.Add(new Language() { Name = "Robbery", Value = "Robbery" });
            dataSource.Add(new Language() { Name = "Shots Fired", Value = "Shots Fired" });
            //Setup data binding
            this.cb7.DataSource = dataSource;
            this.cb7.DisplayMember = "Name";
            this.cb7.ValueMember = "Value";

            // make it readonly
            this.cb7.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LoadDetectiveAssists()
        {
            string query = "SELECT username, level FROM users;";
            DataTable dt = new DataTable();
            slbAssist.Items.Add("");
            try
            {
                dt.Load(DBConnection.SelectAll(query));

                foreach (DataRow dr in dt.Rows)
                {
                    slbAssist.Items.Add(dr[0].ToString());
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
        }

        private void VictimButton_Click_1(object sender, EventArgs e)
        {
            ShowPanel(0);
        }

        private void CrimeButton_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }
        private void InvestigationButton_Click(object sender, EventArgs e)
        {
            ShowPanel(2);
        }

        private void ShowPanel(int panelNum)
        {
            Panel[] panels = new Panel[] { VictimInfoPanel, CrimeInfoPanel, InvestigationPanel };
            Button [] buttons = new Button[]{VictimButton, CrimeButton, InvestigationButton};
            
            foreach(Button b in buttons)
                b.BackColor = Color.Gray;

            foreach (Panel p in panels)
                p.Visible = false;

            panels[panelNum].Visible = true;
            buttons[panelNum].BackColor = Color.Black;
        }


        private void Submit(object sender, EventArgs e)
        {
            string crimeType = cb7.SelectedValue.ToString();
            if (tb18.Text != "" && crimeType !="none")
            {
                int count = 1;
                string insert = "INSERT INTO reports VALUES(";
                insert += "'" + dtpCrime.Value.ToString("yyyy-MM-dd") + "'";


                bool[] ba = new bool[] {true, true, true, false, true, false, true, true, false, 
                    false, true, true, true, true, false, false, true, true, true, true, true, true, true };

                TextBox[] tb = new TextBox[] {tb02, tb04, tb05, null,tb8, tb9, tb10, tb11,
                                                tb12, tb13, tb14, tb15, tb16, tb17, tb18, tb20,tb21, tb22};

                foreach (TextBox t in tb)
                {
                    //add placeholders for detass
                    insert += ",";
                    if (t != null)
                    {
                        string test = t.Name;
                        if (count == 15)
                        {
                            insert += t.Text;
                            int c = 0;
                            foreach (object o in slbAssist.CheckedItems)
                            {
                                if (c > 0)
                                    insert += ",";
                                insert += "'" + o.ToString() + "'";
                                c++;
                            }
                            while (c < 5)
                            {
                                insert += ",'null'";
                                c++;
                            }
                        }
                        else
                        {
                            if (t.Text != "")
                            {
                                if (ba[count] == true)
                                    insert += "'" + t.Text + "'";
                                else
                                    insert += t.Text;
                            }
                            else
                            {
                                if (ba[count] == true)
                                    insert += "'null'";
                                else
                                    insert += "null";
                            }
                        }
                    }
                    else
                    {
                        insert += "'" + crimeType + "'";
                    }

                    count++;
                }

                insert += ");";
                string[] split = insert.Split(',');
                if (DBConnection.CompaintNumberCheck(split[15]))
                {
                    DBConnection.Insert(insert);
                    mv.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Error: Deplicate Complaint Number {0}", split[15]);

            }
            else
                MessageBox.Show("* Indicated Required Input");
        }

        private void Return(object sender, FormClosingEventArgs e)
        {
            mv.Show();
            this.Hide();
            
        }

    }
}
