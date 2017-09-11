using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            string[] userInput = new string[] { "first", "second", "third", "fourh" };

            printer(userInput);

            Console.ReadKey();

        }

        static void printer(string[] userInput)
        {
            foreach (string str in userInput)
            {
                Console.WriteLine(str);
            }
        }
    }
}
