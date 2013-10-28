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
    public partial class EditForm : Form
    {
        string value, header;
        public EditForm(string value, string header)
        {
            InitializeComponent();
            this.value = value;
            this.header = header;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            
            string[] split = value.Split('?');
            string[] split2 = header.Split(',');
            dataGridView1 = DGV_Creation(dataGridView1,  split, split2);
            dataGridView1.Refresh();
            var height = 40;
            
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                height += dr.Height;
            }

            //dataGridView1.Height = height;

        }
        private DataGridView DGV_Creation(DataGridView dgv, string[]splitvalue, string[]splitheader)
        {
            for (int j = 0; j < splitheader.Length; j++)
            {
                dgv.Columns.Add(j.ToString(),splitheader[j].ToString());
            }
            //dgv.Rows.Add("Head", "Fields");
            //dgv.Rows.Add("Values", "Values");
            for (  int i = 0; i < 2; i++)
            {
               // dgv.Columns.Add(
            }

            return dgv;
        }
    }
}
