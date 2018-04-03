using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace designpatterns
{
    public partial class Form1 : Form
    {
        public List<CoinData> coins;
        private AbstractMainState state;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            coins = new List<CoinData>();
            state = new SortState();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CoinClient C = new CoinClient(this);
            Converter converter;

            converter = new EuroConverter();
            converter.update();

            converter = new CanadianDollarConverter();
            converter.update();

        }
        public void doshit(CoinData[] coins)
        {
            this.coins.Clear();   
            foreach (CoinData c in coins)
            {
                this.coins.Add(c);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            state = new SortState();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            state = new FilterState();
        }
    }
}
