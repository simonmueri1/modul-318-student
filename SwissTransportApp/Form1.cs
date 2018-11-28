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

        private void cmbStartStation_KeyPress(object sender, KeyPressEventArgs e)
        {
            var input = cmbStartStation.SelectedItem;

            StationFinder stationFinder = new StationFinder();
            stationFinder.findStation(input);
        }
    }
}
