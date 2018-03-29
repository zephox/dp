using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace designpatterns
{
    public partial class Form1 : Form
    {
        public List<CoinData> coins;
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CoinClient C = new CoinClient(this);
        }
        public void doshit(CoinData[] coins)
        {
            foreach (CoinData c in coins)
            {

            }
        }
    }
}
