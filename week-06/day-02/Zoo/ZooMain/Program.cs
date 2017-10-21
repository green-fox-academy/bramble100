using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo;

namespace ZooMain
{
    class Program
    {
        static void Main(string[] args)
        {
            var reptile = new Reptile("Crocodile");
            var mammal = new Mammal("Koala");
            var bird = new Bird("Parrot");

            Console.WriteLine("Who want a baby?");
            Console.WriteLine(reptile.Name + ", " + reptile.WantChild());
            Console.WriteLine(mammal.Name + ", " + mammal.WantChild());
            Console.WriteLine(bird.Name + ", " + bird.WantChild());
            Console.ReadKey();
        }
    }
}
