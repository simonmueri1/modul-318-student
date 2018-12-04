using System.Net;

namespace SwissTransportApp
{
    class CheckInternet
    {
        public CheckInternet()
        {

        }

        public bool checkForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
