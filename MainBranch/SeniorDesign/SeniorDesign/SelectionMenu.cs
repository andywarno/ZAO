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
    public partial class SelectionMenu : Form
    {
        public SelectionMenu()
        {
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                MainView SF = new MainView();
                SF.Show();
                this.Hide();
            }
        }

       
    }
}
