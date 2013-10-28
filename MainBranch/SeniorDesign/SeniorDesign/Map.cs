using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace SeniorDesign
{
    public partial class Map : Form
    {
        double precision = 1.0;
        List<PointLatLng> Coordinates;
        List<string> Address;
        public Map(List<PointLatLng> Coordinates, List<string>Address)
        {
            InitializeComponent();
            this.Coordinates = Coordinates;
            this.Address = Address;
        }

        private void Map_Load(object sender, EventArgs e)
        {
            //IDEAS: Set marker colors to Crimetype, add text to marker
            gmc1.MapProvider = GoogleMapProvider.Instance;
            gmc1.Manager.Mode = AccessMode.ServerOnly;//only get tiles from server
            GMapProvider.WebProxy = null;//for connection issues
            gmc1.Position = new PointLatLng(42.11671, -86.45419);//center at Benton Harbor
            GMapOverlay myOverlay = new GMapOverlay(gmc1, "Reports");
            
            for (int i = 0; i < Coordinates.Count; i++)
            {
                myOverlay.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(Coordinates[i]));
                myOverlay.Markers[i].ToolTipText = Address[i].ToString();
                //maybe custom markers
            }
            gmc1.MinZoom = 1;
            gmc1.MaxZoom = 20;
            gmc1.Zoom = 10;
            gmc1.Overlays.Add(myOverlay);//Add Markers
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            gmc1.Zoom += precision;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            gmc1.Zoom -= precision;
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            MainView mv = new MainView();
            this.Hide();
            mv.Show();
        }
    }
}
