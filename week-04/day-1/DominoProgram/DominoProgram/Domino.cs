using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoProgram
{
    class Domino
    {
        public List<int> Sides;

        public Domino(int side1, int side2) => Sides = new List<int>() { side1, side2 };
    }
}
