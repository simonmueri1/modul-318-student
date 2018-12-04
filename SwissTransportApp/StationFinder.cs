using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportApp
{
    class StationFinder
    {
        public StationFinder()
        {

        }
         
        /// <summary>
        /// Returns a List of Stations With the Beginning of the ComboBox input
        /// </summary>
        /// <param name="input">Input from ComboBox</param>
        /// <returns>List of Station</returns>
        public List<Station> FindStations(string input)
        {
            ITransport transport = new Transport();
            return transport.GetStations(input).StationList;
        }

        /// <summary>
        /// Checks if Station exists
        /// </summary>
        /// <param name="station">Station Name</param>
        /// <returns>bool</returns>
        public bool IsStationAvailable(string station)
        {   
            StationFinder stationFinder = new StationFinder();
            List<Station> stations = stationFinder.FindStations(station);
            
            if(stations.Count > 0)
                return true;

            return false;
        }

        /// <summary>
        /// Returns First Station of List with Name from ComboBox
        /// </summary>
        /// <param name="name">ComboBox input</param>
        /// <returns>Station</returns>
        public Station FindStation(string name)
        {
            return FindStations(name).First();
        }
    }
}
