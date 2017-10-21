using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercise01
    {
        public static void Run()
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbersLinq = from number in n
                                  where number % 2 == 0
                                  select number;

            evenNumbersLinq.ToList().ForEach(x => Console.WriteLine(x));
        }

    }
}
