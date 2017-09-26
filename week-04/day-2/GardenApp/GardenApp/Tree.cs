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

        public bool NeedsWatering()
        {
            return water < 10;
        }

        public void Water(int water)
        {
            this.water += (int)(water * 0.4);
        }

        internal string DisplayStatusReport()
        {
            return $"The {color} tree {(NeedsWatering() ? "needs" : "doesn't need")} water";
        }
    }
}