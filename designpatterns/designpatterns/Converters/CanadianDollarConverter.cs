using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpatterns
{
    class CanadianDollarConverter : Converter
    {
        public override void convert(string @base)
        {
            
        }

        public override void update()
        {
            Debug.WriteLine("converted from canadian dollar");
        }
    }
}
