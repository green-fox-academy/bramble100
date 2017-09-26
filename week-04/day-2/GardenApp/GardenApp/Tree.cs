using System;

namespace GardenApp
{
    internal class Tree : Plant
    {
        private static string name = "tree";

        public Tree(string color) => this.color = color;

        public override bool NeedsWatering() => water < 10;

        public override void Water(int water) => this.water += (int)(water * 0.4);

        internal override string DisplayStatusReport() => $"The {color} {name} {(NeedsWatering() ? "needs" : "doesn't need")} water";
    }
}