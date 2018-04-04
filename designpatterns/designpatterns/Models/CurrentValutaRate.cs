using System;
using Json = Newtonsoft.Json.JsonPropertyAttribute;

namespace designpatterns
{
    class CurrentValutaRate : Valuta
    {
        public double euroRate;
        public double canadiandDollarRate;
        public CurrentValutaRate request()
        {
            return new CurrentValutaRate();
        }
        public CurrentValutaRate()
        {
            euroRate = 0.86;
            canadiandDollarRate = 1.23;
        }
    }
}