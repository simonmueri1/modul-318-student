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

        public void findStation(object input)
        {
            Transport transport = new Transport();
            var stations = transport.GetStations(input).Result.StationList;
        }
    }
}
