﻿using System;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection dbConn = new DBConnection(txtUser.Text, txtPass.Text);
            if (dbConn._ConnectToDB())
            {
                SelectionMenu SM = new SelectionMenu();
                SM.Show();
                //MainView mv = new MainView();
                //mv.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Access Denied: Invalid Username/Password");
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
