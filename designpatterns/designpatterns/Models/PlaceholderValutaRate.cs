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
       

        public CurrentValutaRate request()
        {
            if(cvr == null)
            {
                cvr = new CurrentValutaRate();
                return cvr.request();
            }
            else
            {
                return cvr.request();
            }
        }
    }
}
