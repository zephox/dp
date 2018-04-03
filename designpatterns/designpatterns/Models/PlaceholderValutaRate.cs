using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpatterns
{
    class PlaceholderValutaRate : Valuta
    {
       public string getBase()
        {
            return "1.23";
        }
    }
}
