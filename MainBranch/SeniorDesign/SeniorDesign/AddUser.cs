using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace SeniorDesign
{
    public partial class UserMenu : Form
    {
        string connStr = "server=localhost;user=" + CurrentUser._user + ";database=crimereport;" +
                                "port=3306;password=" + CurrentUser._pass + ";";
        public UserMenu()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            fillUserTable();
        }
        private void fillUserTable()
        {
            string query = "SELECT username, level FROM users;";
            DataTable dt = new DataTable();
            try
            {
                dt.Load(DBConnection.SelectAll(query));

                dataGridView.DataSource = null;
                dataGridView.DataSource = dt;
                dataGridView.Refresh();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser();
            nu.Show();

            fillUserTable();
            
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                if (r.Selected)
                {
                    string temp = r.Cells[0].Value.ToString();
                    string query = "DELETE FROM users WHERE username='" + temp + "';";
                    DBConnection.Delete(query);
                }
            }
            fillUserTable();
            //if carl do not let delete
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillUserTable();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            string temp = "";
            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                if (r.Selected)
                {
                    temp = r.Cells[0].Value.ToString();
                }
            }
            NewUser._isEdit = true;
            NewUser nu = new NewUser(temp);
            nu.Show();
        }


    }
}
