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
            WithLinqExpression(n);
            WithMethodExpression(n);
        }

        private static void WithLinqExpression(int[] numbersArray)
        {
            Console.WriteLine("Linq expression:");

            var numbersLinq = from number in numbersArray
                              select number;

            numbersLinq
                .ToList()
                .ForEach(x => Console.WriteLine($"{x}"));
        }

        private static void WithMethodExpression(int[] numbersArray)
        {
            Console.WriteLine("Method expression:");
            numbersArray
                .ToList()
                .Distinct()
                .ToList()
                .OrderBy(number => number)
                .ToList()
                .ForEach(number
                    => Console.WriteLine($"{number}: {numbersArray.Count(number2 => number == number2)}"));
        }
    }
}
