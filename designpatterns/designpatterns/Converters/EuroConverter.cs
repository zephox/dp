using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpatterns
{
    class EuroConverter : Converter
    {
        public override void convert(string @base)
        {
           
        }

        public override void update()
        {
            foreach (CoinData CD in Coin)
            {
                CD.PriceUsd = (double.Parse(CD.PriceUsd) * 0.815228468).ToString();
                
            }
        }
    }
}
