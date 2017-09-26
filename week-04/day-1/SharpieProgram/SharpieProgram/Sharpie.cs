using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieProgram
{
    class Sharpie
    {
        private string Color;
        private float Width;
        private int InkAmount = 100;

        public Sharpie(string color, float width)
        {
            Color = color;
            Width = width;
        }

        public void Use() => InkAmount--;
    }
}
