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
        }
        private void LoadDetectiveAssists()
        {
            string query = "SELECT username, level FROM users;";
            DataTable dt = new DataTable();
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
            slbAssist.Items[0] = "";
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
            if (tb18.Text != "")
            {
                int count = 1;
                string insert = "INSERT INTO reports VALUES(";
                insert += "'" + dtpCrime.Value.ToString("yyyy-MM-dd") + "'";

                bool[] ba = new bool[] {true, true, true, false, true, false, true, true, false, 
                    false, true, true, true, true, false, false, true, true, true, true, true, true, true };

                TextBox[] tb = new TextBox[] {tb02, tb04, tb05, tb7, tb8, tb9, tb10, tb11,
                                                tb12, tb13, tb14, tb15, tb16, tb17, tb18, tb20,tb21, tb22};

                foreach (TextBox t in tb)
                {
                    //add placeholders for detass
                    string test = t.Name;
                    insert += ",";
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
