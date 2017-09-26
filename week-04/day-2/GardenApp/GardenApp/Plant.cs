using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    abstract class Plant
    {
        private static string name = "plant";

        internal string color;
        internal int water = 0;

        abstract public bool NeedsWatering();

        abstract public void Water(int water);

        internal virtual string DisplayStatusReport()
        {
            return $"The {color} {name} {(NeedsWatering() ? "needs" : "doesn't need")} water";
        }

    }
}
