using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise09
    {
        // Write a LINQ Expression to find the uppercase characters in a string!
        public static void Run()
        {
            char[] charArray = { 'h', 'e', 'l', 'l', 'o' };

            WithLinqExpression(charArray);

            WithMethodExpression(charArray);
        }

        private static void WithLinqExpression(char[] charArray)
        {
            Console.WriteLine("Linq expression:");
        }

        private static void WithMethodExpression(char[] charArray)
        {
            Console.WriteLine("Method expression:");

            Console.WriteLine(charArray.ToList().Aggregate(new StringBuilder(), (a, b) => a.Append(b)));

            // Console.WriteLine(new String(charArray));
        }
    }
}
