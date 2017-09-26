using System;

namespace GardenApp
{
    internal class Tree
    {
        private string color;
        private int water = 0;

        public Tree(string color)
        {
            this.color = color;
        }

        internal string DisplayStatusReport()
        {
            return $"The {color} tree {(NeedsWatering() ? "needs" : "doesn't need")} water";
        }

        private bool NeedsWatering()
        {
            return water < 10;
        }
    }
}