using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpatterns
{
    class PlaceholderValutaRate : Valuta
    {
       private CurrentValutaRate cvr = new CurrentValutaRate();

       public string getBase()
        {
            return cvr.getBase();
        }
    }
}
