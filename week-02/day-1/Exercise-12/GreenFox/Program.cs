using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double edgeA = 10.5;
            double edgeB = 15.4;
            double edgeC = 20.3;

            Console.WriteLine("Surface Area: " + 
                2 * (edgeA * edgeB + edgeA * edgeC + edgeB * edgeC));
            Console.WriteLine("Volume: " +                 edgeA * edgeB * edgeC);

            Console.ReadKey();
        }
    }
}
