using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//#################test
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
            
                if (rbMain.Checked)
                {
                    MainView SF = new MainView();
                    SF.Show();
                    this.Hide();
                }

        }

        private void SelectionMenu_Load(object sender, EventArgs e)
        {

        }

        private void keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (rbMain.Checked)
                {
                    MainView SF = new MainView();
                    SF.Show();
                    this.Hide();
                }
            }

        }

       
    }
}
