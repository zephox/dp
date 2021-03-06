﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpatterns
{
    class EuroConverter : Converter
    {
        public override void update()
        {
            foreach (CoinData coin in CoinData)
            {
                coin.PriceUsd = (double.Parse(coin.PriceUsd) * currentValueRate.euroRate).ToString();
            }
        }
    }
}
