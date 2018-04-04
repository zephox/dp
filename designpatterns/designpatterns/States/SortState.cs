using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designpatterns
{
    class SortState : AbstractMainState
    {
        public override void Handle(Form1 context)
        {
            context.setLabelText("state - Sort");
            var sortedList = context.coins.OrderBy(i => i.Name).ToList();
            context.coins = sortedList;
        }
    }
}
