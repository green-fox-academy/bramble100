using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();
            garden.AddFlowers(new List<Flower>() {
                new Flower("yellow"),
                new Flower("blue")
            });
            garden.AddTrees(new List<Tree>() {
                new Tree("purple"),
                new Tree("orange")
            });
            garden.DisplayStatusReport();

            garden.Water(40);
            garden.DisplayStatusReport();
            garden.Water(70);
            garden.DisplayStatusReport();

            Console.ReadKey();
        }
    }
}