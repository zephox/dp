using System.Net;
using System.Timers;

namespace designpatterns
{
    class ValutaClient
    {
        private System.Timers.Timer timer;
        private Form1 form1;

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            using (WebClient client = new WebClient())
            {
               // string json = client.DownloadString("");
            }
        }
        public ValutaClient(Form1 form1)
        {
            this.form1 = form1;
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = 10000;
            timer.Enabled = true;
            timer.Start();
        }
    }
}
