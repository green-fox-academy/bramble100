using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`

            int[] ai = new int[] { 3, 4, 5, 6, 7 };

            Console.WriteLine(ai.Sum());

            int sum = 0;
            foreach(int i in ai)
            {
                sum += i;
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
