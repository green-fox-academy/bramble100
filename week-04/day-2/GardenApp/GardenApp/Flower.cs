using System;

namespace GardenApp
{
    internal class Flower
    {
        private string color;
        private int water = 0;

        public Flower(string color)
        {
            this.color = color;
        }

        public bool NeedsWatering()
        {
            return water < 5;
        }

        public void Water(int water)
        {
            this.water += (int)(water * 0.75);
        }

        internal string DisplayStatusReport()
        {
            return $"The {color} flower {(NeedsWatering() ? "needs" : "doesn't need")} water";
        }
    }
}