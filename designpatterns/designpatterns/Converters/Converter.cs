using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpatterns
{
    abstract class Converter
    {
        protected List<CoinData> Coin = new List<CoinData>();
        protected CurrentValutaRate cvr;
        public CurrentValutaRate currentValueRate
        {
            get { return cvr; }
            set { cvr = value; }
        }
        public List<CoinData> CoinData
        {
            get { return Coin; }
            set { Coin = value; }
        }
        public abstract void update();
    }
}
