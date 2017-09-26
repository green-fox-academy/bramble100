using System;

namespace GardenApp
{
    internal class Flower : Plant
    {
        private static string name = "flower";

        public Flower(string color) => this.color = color;

        public override bool NeedsWatering() => water < 5;

        public override void Water(int water) => this.water += (int)(water * 0.75);

        internal override string DisplayStatusReport() => $"The {color} {name} {(NeedsWatering() ? "needs" : "doesn't need")} water";
    }
}