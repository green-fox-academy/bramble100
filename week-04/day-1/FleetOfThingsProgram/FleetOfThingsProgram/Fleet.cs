using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThingsProgram
{
    class Fleet : List<Thing>
    {
        public new void Add(Thing thing) => base.Add(thing);

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            ForEach(x => stringBuilder.AppendLine(x.ToString()));
            return stringBuilder.ToString();
        }
    }
}
