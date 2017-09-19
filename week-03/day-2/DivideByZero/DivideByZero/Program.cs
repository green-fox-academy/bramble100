using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0
            Console.WriteLine(Divide(2,0));
            Console.ReadKey();
        }

        static double Divide(double nominator, double divider)
        {
            try
            {
                int result = (int)nominator / (int)divider;
                //double result = nominator / divider;
                return (double)result;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero :(");
                return 0;
            }
        }
    }
}
