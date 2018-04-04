using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace designpatterns
{
    public partial class Form1 : Form, AbstractCoinObserver
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
            CoinClient CC = new CoinClient(this);
            CC.register(this);
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
            state.Handle(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            state = new FilterState();
            state.Handle(this);
        }
        public void setLabelText(string text)
        {
            label1.Text = text;
        }

        public void update()
        {
            Debug.WriteLine("data changed");
            listBox1.Items.Clear();

            Converter converter;
            converter = new EuroConverter();//builder
            converter.update();

            foreach (CoinData c in coins)
            {
                listBox1.Items.Add(c.Name + " - " + c.PriceUsd);
            }
        }
    }
}
