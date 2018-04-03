using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpatterns
{
    abstract class Converter
    {
        protected CoinData Coin;
        public CoinData CoinData
        {
            get { return Coin; }
        }
        public abstract void update();
        public abstract void convert(string @base);
    }
}
