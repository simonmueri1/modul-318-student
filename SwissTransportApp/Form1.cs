using SwissTransport;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SwissTransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckInternet checkInternet = new CheckInternet();
            bool internetAvaiability = checkInternet.checkForInternetConnection();

            if (internetAvaiability == false)
            {
                MessageBox.Show("Keine Internetverbindung", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            
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

            cmbStartStation.DroppedDown = true;
            e.Handled = true;
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

            cmbEndStation.DroppedDown = true;
            e.Handled = true;
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
                MessageBox.Show("Station: \"" + cmbStartStation.Text + "\" nicht gefunden.");
                return;
            }
            
            if (!stationFinder.IsStationAvailable(cmbEndStation.Text))
            {
                MessageBox.Show("Station: \"" + cmbEndStation.Text + "\" nicht gefunden.");
                return;
            }

            DateTime dateTime = dateTimePicker1.Value.Date;
            dateTime += dateTimePicker2.Value.TimeOfDay;
            bool isArrivalTime = false;

            if (rdbArrival.Checked)
            {
                isArrivalTime = true;
            }

            connections = transport.GetConnections(cmbStartStation.Text, cmbEndStation.Text, dateTime, isArrivalTime);
            lsbResult1.Items.Clear();

            foreach (Connection elem in connections.ConnectionList)
            {
                string paddedFrom = elem.From.Station.Name + "(" + elem.From.Departure.ToString("HH:mm") + ")".PadRight(10) + "-".PadRight(10);
                string paddedTo = elem.To.Station.Name + "(" + elem.To.Arrival.ToString("HH:mm") + ")".PadRight(10);
                lsbResult1.Items.Add(paddedFrom + paddedTo + elem.Duration.Remove(0, 3).Remove(5, 3));
            }
        }

        private void btnDeparture_Click(object sender, EventArgs e)
        {
            ITransport transport = new Transport();
            StationFinder stationFinder = new StationFinder();

            if (!stationFinder.IsStationAvailable(cmbStartStation.Text))
            {
                MessageBox.Show("Station: \"" + cmbStartStation.Text + "\" nicht gefunden.");
                return;
            }

            Station station = stationFinder.FindStation(cmbStartStation.Text);
            string id = station.Id;
            DateTime dateTime = dateTimePicker1.Value.Date;
            dateTime += dateTimePicker2.Value.TimeOfDay;
            
            lsbResult1.Items.Clear();
            lsbResult1.Items.Add("Abfahrten ab: " + transport.GetStationBoard(cmbStartStation.Text, id, dateTime).Station.Name + "\n");

            foreach(StationBoard elem in transport.GetStationBoard(cmbStartStation.Text, id, dateTime).Entries)
            {
                string paddedTo = elem.To.PadRight(25);
                string paddedInfo = elem.Category.ToString() + elem.Number.ToString();
                paddedInfo = paddedInfo.PadRight(20);
                lsbResult1.Items.Add(paddedTo + paddedInfo + elem.Stop.Departure + "\n");
            }
        }

        private void btnStartMap_Click(object sender, EventArgs e)
        {
            StationFinder stationFinder = new StationFinder();

            if (!stationFinder.IsStationAvailable(cmbStartStation.Text))
            {
                MessageBox.Show("Station: \"" + cmbStartStation.Text + "\" nicht gefunden.");
                return;
            }

            Station station = stationFinder.FindStation(cmbStartStation.Text);
            System.Diagnostics.Process.Start("http://www.google.com/maps/place/" + station.Coordinate.XCoordinate.ToString().Replace(",", ".") + "," + station.Coordinate.YCoordinate.ToString().Replace(",", "."));
        }

        private void btnEndMap_Click(object sender, EventArgs e)
        {
            StationFinder stationFinder = new StationFinder();

            if (!stationFinder.IsStationAvailable(cmbEndStation.Text))
            {
                MessageBox.Show("Station: \"" + cmbEndStation.Text + "\" nicht gefunden.");
                return;
            }
            
            Station station = stationFinder.FindStation(cmbEndStation.Text);
            System.Diagnostics.Process.Start("http://www.google.com/maps/place/" + station.Coordinate.XCoordinate.ToString().Replace(",", ".") + "," + station.Coordinate.YCoordinate.ToString().Replace(",", "."));
        }
    }
}
