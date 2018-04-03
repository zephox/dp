using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpatterns
{
    abstract class AbstractMainState
    {
        public abstract void Handle(Form1 context);
    }
}
