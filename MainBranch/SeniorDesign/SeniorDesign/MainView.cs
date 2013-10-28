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
using System.IO;
using System.Xml;
using System.Xml.Linq;
using GMap.NET;

namespace SeniorDesign
{
    public partial class MainView : Form
    {
        public static List<string[]> rows;
        private static string query, start, end;
        static bool unauthorized;
        public MainView()
        {
            InitializeComponent();
            rows = new List<string[]>();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

            unauthorized = false;
            if (CurrentUser._level != "Administrator")
            {
                btnAddUser.Visible = false;
                unauthorized = true;
            }

            int year = DateTime.Now.Year;

            year = year - 1;//for testing
            dtpStart.Value = new DateTime(year, 1, 1);
            dtpEnd.Value = DateTime.Today;

            refreshDate();
            fillExtraFields();
            addCrimeTypes();
        }
        private void addCrimeTypes()
        {
            //build a list of values
            var dataSource = new List<Language>();
            dataSource.Add(new Language() { Name = "[None]", Value = "none" });
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
            this.cmbCrimeType.DataSource = dataSource;
            this.cmbCrimeType.DisplayMember = "Name";
            this.cmbCrimeType.ValueMember = "Value";

            // make it readonly
            this.cmbCrimeType.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void refreshDate()
        {
            start = dtpStart.Value.ToString("yyyy-MM-dd");
            end = dtpEnd.Value.ToString("yyyy-MM-dd");
        }

        private void fillDataGrid(string query)
        {
            if (query == "")
                query = "SELECT Date, ComplaintNum, Name, Address, Zip, CrimeType, Status FROM reports WHERE Date >= '" + start + "' and Date <= '" + end + "';";
                
            DataTable dt = new DataTable();
            try
            {
                //load the table from the select statement
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

        private void fillExtraFields()
        {
            query = "";
            string[]fields = new string [] {"Name","Address", "Zip", "CrimeType", "Status", "Area", "TimePeriod",
                "PropertyDescription","LostStolenDamagedValue", "Assignment", "FelonyMisd", "GangRel","ArrestsMade", "PrintDna", 
                "Remarks", "DetectiveAssistant1","DetectiveAssistant2","DetectiveAssistant3","DetectiveAssistant4","DetectiveAssistant5"};

            for (int i = 0; i < fields.Length; i++)
            {
                clb.Items.Insert(i, fields[i]);
            }
            for (int i = 0; i < 6; i++)
            {
                clb.SetItemChecked(i, true);
            }
            query = "SELECT Date, ComplaintNum, Name, Address, Zip, CrimeType, Status FROM reports WHERE Date >= '" + start + "' and Date <= '" + end + "';";
            fillDataGrid(query);
        }

        private string OpenEditForm(string value, string header)
        {
            EditForm ef = new EditForm(value, header);
            ef.Show();
            this.Hide();
            return value;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserMenu au = new UserMenu();
            au.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!unauthorized)
            {
                CrimeSheet cs = new CrimeSheet(this);
                cs.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = "";
            query = "SELECT Date, ComplaintNum";//FROM reports;";
            foreach (object itemChecked in clb.CheckedItems)
            {
                query += "," + itemChecked.ToString(); 
            }
            refreshDate();//get new values selected
            string crimeType = cmbCrimeType.SelectedValue.ToString();
            query += " FROM reports WHERE Date >= '" + start + "' and Date <= '" + end;
            //filter by crimeType
            if (crimeType == "none")
                query +=  "';";
            else
                query += "'" +  " and CrimeType='" + crimeType +  "';";

            fillDataGrid(query);
            query = "";
        }

        //Edit Any Cell except Complaint Number
        private void editCell(object sender, DataGridViewCellEventArgs e)
        {
            if (!unauthorized)
            {
                string upquery = "UPDATE reports SET ";
                string header = "";
                DataGridViewRow headerRow = dataGridView.Rows[0];
                foreach (DataGridViewColumn col in dataGridView.Columns)
                    header += col.Name + ",";

                string[] split = header.Split(',');
                foreach (DataGridViewCell c in dataGridView.SelectedCells)
                {
                    int cell = c.ColumnIndex;
                    if (split[cell] != "ComplaintNum")
                    {
                        upquery += split[cell] + "='" + dataGridView[c.ColumnIndex, c.RowIndex].Value.ToString() + "' WHERE ComplaintNum='" + dataGridView.Rows[c.RowIndex].Cells[1].Value.ToString() + "';";
                        DBConnection.Update(upquery);
                        fillDataGrid(query);
                        break;
                    }
                    else
                        MessageBox.Show("Error: Can't edit Complaint Number");
                }
            }
            else
                fillExtraFields();
        }

        private void btnPrintRep_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "CrimeReport_" + DateTime.Today.ToString("dd_MM_yyyy") + ".txt";
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    foreach (DataGridViewRow r in dataGridView.Rows)
                    {
                        string row = "";
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            try
                            {
                                int cell = c.ColumnIndex;
                                string cellVal = r.Cells[cell].Value.ToString();
                                if (cell != 0)
                                    row += cellVal;

                                else
                                    row += cellVal.Substring(0, 8);

                                row += "\t";
                            }
                            catch (NullReferenceException ex)
                            {}
                        }sw.WriteLine(row);
                    }
                }
            }
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!unauthorized)
            {
                foreach (DataGridViewCell c in dataGridView.SelectedCells)
                {
                    if (c.ColumnIndex == 1)
                        btnDel.Visible = true;
                    else
                        btnDel.Visible = false;
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!unauthorized)
            {
                string upquery = "DELETE FROM reports WHERE ComplaintNum='";
                foreach (DataGridViewCell c in dataGridView.SelectedCells)
                {
                    upquery += dataGridView[c.ColumnIndex, c.RowIndex].Value.ToString() + "';";
                    DBConnection.Delete(upquery);
                    fillDataGrid(query);
                }
            }
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
           
            List<string> list = new List<string>();
            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    try
                    {
                        int cell = c.ColumnIndex;
                        string value = r.Cells[cell].Value.ToString() + " ";
                        if (cell == 3)
                        {
                            if (value != null)
                            {
                                string zip = r.Cells[cell + 1].Value.ToString();
                                string query = "Select * from zipcode where ZIP='" + zip + "';";
                                List<string> cityState = DBConnection.Select(query);
                                value += cityState[0].ToString()  + " " + zip;
                                list.Add(value);
                            }
                        }
                    }
                    catch (Exception ex)
                    { }
                }
            }
            List<PointLatLng> Coordinates = new List<PointLatLng>();
            foreach (string s in list)
            {
                float[]latLongArray = GetLatLongForAddress(s);
                Coordinates.Add(new PointLatLng(latLongArray[0], latLongArray[1]));
            }

            Map m = new Map(Coordinates , list);
            this.Hide();
            m.Show();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            Chart c = new Chart();
            this.Hide();
            c.Show();
        }
        public float[] GetLatLongForAddress(string location)
        {
            float[] latLong = new float[2];
            string result = string.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=true", location);

            var doc = XDocument.Load(result);
            string status = doc.Element("GeocodeResponse").Element("status").Value;

            if (status.Equals("OK"))
            {
                //get lat&long from xml response
                var point = doc.Element("GeocodeResponse").Element("result").Element("geometry").Element("location");
                latLong[0] = (float)Convert.ToDouble(point.Element("lat").Value);
                latLong[1] = (float)Convert.ToDouble(point.Element("lng").Value);

            }
            else if (status.Equals("ZERO_RESULTS"))
            {
                throw new ApplicationException("No maps found for this address");
            }
            else if (status.Equals("REQUEST_DENIED"))
            {
                throw new ApplicationException("Request Denied");
            }
            else if (status.Equals("INVALID_REQUEST"))
            {
                throw new ApplicationException("Address not found");
            }
            else if (status.Equals("UNKNOWN_ERROR"))
            {
                //the request could not be processed due to a server error, try again
                GetLatLongForAddress(location);
            }
            return latLong;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();

        }
        private void Search()
        {
            string search = txtSearchBox.Text;
            if (search != "")
            {
                query = "";
                query = "SELECT Date, ComplaintNum, Name, Address, Zip, CrimeType, BusinessName,Remarks Status FROM reports WHERE" +
                " ComplaintNum='" + search + "' OR" +
                " Name LIKE '%" + search + "%' OR" +
                " Address LIKE '%" + search + "%' OR" +
                " BusinessName LIKE '%" + search + "%' OR" +
                " Remarks LIKE '%" + search + "%';";
            }
            else
                query = "SELECT Date, ComplaintNum, Name, Address, Zip, CrimeType, Status FROM reports WHERE Date >= '" + start + "' and Date <= '" + end + "';";

            fillDataGrid(query);
        }
        
    }
}
