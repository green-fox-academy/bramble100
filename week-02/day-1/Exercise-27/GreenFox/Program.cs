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
            // Write a program that prints the numbers from 1 to 100.
            // But for multiples of three print “Fizz” instead of the number
            // and for the multiples of five print “Buzz”.
            // For numbers which are multiples of both three and five print “FizzBuzz”.

            for (int i = 1; i < 101; i++)
            {
                //Console.WriteLine(i % 3 == 0 || i % 5 == 0 ? 
                //    "Fizz or Buzz" : 
                //    i.ToString());
                Console.WriteLine(i % 3 == 0 ?
                    (i % 5 == 0 ? "FizzBuzz" : "Fizz") :
                    (i % 5 == 0 ? "Buzz" : i.ToString()));
            }
            Console.ReadKey();
        }
    }
}
