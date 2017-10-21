using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printable
{
    class Domino : IComparable, IPrintable
    {
        public List<int> Sides;

        public Domino(int side1, int side2) => Sides = new List<int>() { side1, side2 };

        public void printAllFields()
        {
            Console.WriteLine(ToString()); ;
        }

        int IComparable.CompareTo(object obj)
        {
            Domino other = (Domino) obj;
            return Sides[0]==other.Sides[0] ? Sides[1].CompareTo(other.Sides[1]) : Sides[0].CompareTo(other.Sides[0]);
        }

        public override string ToString() => $"({Sides[0]}, {Sides[1]})";
    }
}
