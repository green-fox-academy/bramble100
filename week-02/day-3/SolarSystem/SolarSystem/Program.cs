using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus",
            "Neptune" };


            // Saturn is missing from the planetList
            // Insert it into the correct position

            planetList.Insert(5, "Saturn");

            foreach (string s in planetList)
            {
                Console.WriteLine(s);
            }
            
            Console.ReadKey();
        }
    }
}
