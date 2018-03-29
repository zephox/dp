using System.Net;
using System.Timers;

namespace designpatterns
{
    class ValutaClient
    {
        private System.Timers.Timer timer;
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            
        }
        public ValutaClient()
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = 10000;
            timer.Enabled = true;
            timer.Start();
        }
        public void getValuta()
        {
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/");
            }
        }
    }
}
