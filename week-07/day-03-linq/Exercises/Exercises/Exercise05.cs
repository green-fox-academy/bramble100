using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise05
    {
        public static void Run()
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            Console.WriteLine("Linq expression:");

            var numbersLinq = from number in n
                              where number * number > 20
                              orderby number
                              select number;

            Console.WriteLine("Method expression:");
            n
                .ToList()
                .Distinct()
                .ToList()
                .OrderBy(number => number)
                .ToList()
                .ForEach(number
                    => Console.WriteLine($"{number}: {n.Count(number2 => number == number2)}"));
        }
    }
}
