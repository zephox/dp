using System.Timers;
using Newtonsoft.Json;
using System.Net;
using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace designpatterns
{
    class CoinClient
    {
        private System.Timers.Timer timer;
        public Form1 form;
        private List<ICoinObserver> observers = new List<ICoinObserver>();

        public void register(ICoinObserver ACO)
        {
            observers.Add(ACO);
        }
        public void notify()
        {
            foreach (ICoinObserver observer in observers)
            {
                observer.update();
            }
        }


        //timertje voor api
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
                form.doWork(coins);
                this.notify();
            }
        }
    }
}
