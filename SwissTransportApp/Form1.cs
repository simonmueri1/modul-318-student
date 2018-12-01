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
            
            foreach(Connection item in connections.ConnectionList)
            {
                lsbResult.Items.Clear();
                lsbResult.Items.Add(item.From.Station.Name + " " + item.To.Station.Name + " " + item.Duration + " " + item.From.ArrivalTimestamp);
            }
        }

        private void btnDeparture_Click(object sender, EventArgs e)
        {
            ITransport transport = new Transport();
            StationFinder stationFinder = new StationFinder();

            Station station = stationFinder.FindStation(cmbStartStation.Text);
            string id = station.Id;

            lsbResult.Items.Clear();
            lsbResult.Items.Add(transport.GetStationBoard(cmbStartStation.Text, id).Station.Name);
            foreach(StationBoard elem in transport.GetStationBoard(cmbStartStation.Text, id).Entries)
            {
                lsbResult.Items.Add("---");
                lsbResult.Items.Add(elem.Name);
                lsbResult.Items.Add(elem.Number);
                lsbResult.Items.Add(elem.Operator);
                lsbResult.Items.Add(elem.Stop.Departure);
                lsbResult.Items.Add(elem.To);
            }
        }
    }
}
