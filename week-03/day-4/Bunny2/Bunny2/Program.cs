using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny2
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
            for (int numberOfBunnies = 1; numberOfBunnies < 51; numberOfBunnies++)
            {
                Console.WriteLine($"{numberOfBunnies}: { NumberOfEars(numberOfBunnies)}");
            }
            Console.ReadKey();

        }

        private static int NumberOfEars(int numberOfBunnies)
        {
            if (numberOfBunnies < 2)
            {
                return 2;
            }
            return (numberOfBunnies % 2 == 0 ? 3 : 2) + NumberOfEars(numberOfBunnies - 1);
        }
    }
}
