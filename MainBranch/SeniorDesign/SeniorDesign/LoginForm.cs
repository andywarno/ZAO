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
    public partial class formLogin : Form 
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load previous user
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {
        }

        private void enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
            {
                login();
            }
        }
        private void login()
        {
            if (CurrentUser.checkPassword(txtUser.Text, txtPass.Text))
            {
                CurrentUser._user = txtUser.Text;
                CurrentUser._pass = txtPass.Text;
                SelectionMenu SM = new SelectionMenu();
                SM.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Access Denied: Invalid Username/Password");
        }


    }
}
