using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpatterns
{
    class CanadianDollarConverter : Converter
    {
        public override void convert(string @base)
        {
            CoinData.PriceUsd = 11232.ToString();
        }

        public override void update()
        {      
             
        }
    }
}
