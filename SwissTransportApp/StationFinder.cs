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

        public List<Station> FindStations(string input)
        {
            ITransport transport = new Transport();
            return transport.GetStations(input).StationList;
        }

        public bool IsStationAvailable(string station)
        {   
            StationFinder stationFinder = new StationFinder();
            List<Station> stations = stationFinder.FindStations(station);
            
            if(stations.Count > 0)
                return true;

            return false;
        }

        public Station FindStation(string name)
        {
            return FindStations(name).First<Station>();
        }
    }
}
