using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpatterns
{
    class PlaceholderValutaRate : Valuta
    {
        private CurrentValutaRate cvr;
       

        public string request()
        {
            if(cvr == null)
            {
                cvr = new CurrentValutaRate();
                return cvr.getBase();
            }
            else
            {
                return cvr.getBase();
            }
        }
    }
}
