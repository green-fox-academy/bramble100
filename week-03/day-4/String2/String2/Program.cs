using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.
            string input = "Xerxes got X-rayed by Xanthippe.";
            Console.WriteLine(DeXize(input));
            Console.ReadKey();
        }

        private static string DeXize(string input)
        {
            return input.Length < 2 ? 
                input : 
                input[0].ToString().ToLower() == "x" ? 
                    DeXize(input.Substring(1)) : 
                    $"{input[0]}{DeXize(input.Substring(1))}";

            //if(input.Length < 2)
            //{
            //    return input;
            //}
            //if (input[0].ToString().ToLower() == "x")
            //{
            //    return DeXize(input.Substring(1));
            //}
            //return $"{input[0]}{DeXize(input.Substring(1))}";
        }
    }
}
