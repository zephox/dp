using System.Timers;
using Newtonsoft.Json;
using System.Net;
using System.Diagnostics;

namespace designpatterns
{
    class CoinClient
    {
        private System.Timers.Timer timer;
        public Form1 form;
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            getCoinData();
        }
        public CoinClient(Form1 f)
        {
            this.form = f;
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = 10000;
            timer.Enabled = true;
            timer.Start();
        }
        public void getCoinData()
        {
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/");
                CoinData[] coins = JsonConvert.DeserializeObject<CoinData[]>(json);
                form.doshit(coins);
            }
        }
    }
}
