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
    public partial class NewUser : Form
    {
        private string user;
        static bool isEdit;
        public static bool _isEdit { get { return isEdit; } set { isEdit = value; } }
        public NewUser()
        {
            InitializeComponent();
        }
        public NewUser(string info)
        {
            InitializeComponent();
            txtUserName.Text = info;
            btnCreate.Text = "Update User";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            if (btnCreate.Text == "Create")
            {
                if (txtPass1.Text == txtPass2.Text && txtPass1.Text != "" && txtUserName.Text != "")
                {
                    //update password
                    string password = CurrentUser.GenerateHashWithSalt(txtPass1.Text);
                    string level = cmbSecurity.Text;

                    string query = "INSERT INTO users VALUES('" + username + "','" + password + "','" + level + "');";
                    DBConnection.Insert(query);
                    this.Hide();
                }
            }
            else if (btnCreate.Text == "Update User")
            {
                //username is auto filled
                if (txtPass1.Text != "")
                {
                    //update password and level
                    MessageBox.Show("Caution: you are about to Change the password and security level");
                    string password = CurrentUser.GenerateHashWithSalt(txtPass1.Text);
                    string level = cmbSecurity.Text;

                    string query = "update users set username='" + username + "', passowrd='" + password + "', level='" + level + "' where username ='" + username + "';";
                    DBConnection.Update(query);
                    this.Hide();
                }
                else
                {
                    //update level
                    MessageBox.Show("Caution: you are about to Change the security level");

                    string level = cmbSecurity.Text;
                    string query = "UPDATE users SET username='" + username + "', level='" + level + "' WHERE username ='" + username + "';";
                    DBConnection.Update(query);
                    this.Hide();
                }
            }
            
            else
            {
                //update level
                MessageBox.Show("Passwords do not match");
                txtPass1.Text = "";
                txtPass2.Text = "";
            }
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("user", "User");
            test.Add("admin", "Administrator");

            cmbSecurity.DataSource = new BindingSource(test, null);
            cmbSecurity.DisplayMember = "Value";
            cmbSecurity.ValueMember = "Key";
        }

    }
}
