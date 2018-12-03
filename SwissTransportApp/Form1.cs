using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
        
        private void cmbStartStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            cmbStartStation.Items.Clear();

            var input = cmbStartStation.Text;
            StationFinder stationFinder = new StationFinder();
            List<Station> stations = stationFinder.FindStations((string)input);

            foreach (Station element in stations)
            {
                cmbStartStation.Items.Add(element.Name);
            }
        }

        private void cmbEndStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            cmbEndStation.Items.Clear();

            var input = cmbEndStation.Text;
            StationFinder stationFinder = new StationFinder();
            List<Station> stations = stationFinder.FindStations((string)input);

            foreach (Station element in stations)
            {
                cmbEndStation.Items.Add(element.Name);
            }
        }

        private void btnConnections_Click(object sender, EventArgs e)
        {
            Station stationFrom = new Station();
            Station stationTo = new Station();
            StationFinder stationFinder = new StationFinder();
            ITransport transport = new Transport();
            Connections connections;

            if (!stationFinder.IsStationAvailable(cmbStartStation.Text))
            {
                MessageBox.Show(cmbStartStation.Text + " als Station nicht gefunden");
                return;
            }
            
            if (!stationFinder.IsStationAvailable(cmbEndStation.Text))
            {
                MessageBox.Show(cmbEndStation.Text + " als Station nicht gefunden");
                return;
            }
            
            connections = transport.GetConnections(cmbStartStation.Text, cmbEndStation.Text);
            lsbResult1.Items.Clear();

            foreach (Connection elem in connections.ConnectionList)
            {
                lsbResult1.Items.Add(elem.From.Station.Name + " " + elem.From.DepartureTimestamp + elem.From.Departure + "\t" + elem.To.Station.Name + "\t" + elem.From.ArrivalTimestamp + elem.Duration);
            }
        }

        private void btnDeparture_Click(object sender, EventArgs e)
        {
            ITransport transport = new Transport();
            StationFinder stationFinder = new StationFinder();

            Station station = stationFinder.FindStation(cmbStartStation.Text);
            string id = station.Id;
            
            if (!stationFinder.IsStationAvailable(cmbStartStation.Text))
            {
                MessageBox.Show(cmbStartStation.Text + " als Station nicht gefunden");
                return;
            }
            
            lsbResult1.Items.Clear();
            lsbResult1.Items.Add("Abfahrten ab: " + transport.GetStationBoard(cmbStartStation.Text, id).Station.Name);
            foreach(StationBoard elem in transport.GetStationBoard(cmbStartStation.Text, id).Entries)
            {
                lsbResult1.Items.Add(elem.To + "\t\t\t" + elem.Category + elem.Number + "\t\t" + elem.Stop.Departure + "\n");
            }
        }

        private void btnStartMap_Click(object sender, EventArgs e)
        {
            var input = cmbStartStation.Text;
            StationFinder stationFinder = new StationFinder();
            Station station = stationFinder.FindStation(cmbStartStation.Text);

            if (!stationFinder.IsStationAvailable(cmbStartStation.Text))
            {
                MessageBox.Show(cmbStartStation.Text + " als Station nicht gefunden");
                return;
            }
            
            System.Diagnostics.Process.Start("http://www.google.com/maps/place/" + station.Coordinate.XCoordinate.ToString().Replace(",", ".") + "," + station.Coordinate.YCoordinate.ToString().Replace(",", "."));
        }

        private void btnEndMap_Click(object sender, EventArgs e)
        {
            var input = cmbEndStation.Text;
            StationFinder stationFinder = new StationFinder();
            Station station = stationFinder.FindStation(cmbEndStation.Text);

            if (!stationFinder.IsStationAvailable(cmbEndStation.Text))
            {
                MessageBox.Show(cmbEndStation.Text + " als Station nicht gefunden");
                return;
            }

            System.Diagnostics.Process.Start("http://www.google.com/maps/place/" + station.Coordinate.XCoordinate.ToString().Replace(",", ".") + "," + station.Coordinate.YCoordinate.ToString().Replace(",", "."));
        }
    }
}
