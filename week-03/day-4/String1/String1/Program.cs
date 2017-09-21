using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.
            string input = "Xerxes got X-rayed by Xanthippe.";
            Console.WriteLine(ChangeXToY(input));
            Console.ReadKey();
        }

        private static string ChangeXToY(string input)
        {
            if(input.Length < 2)
            {
                if(input == "x")
                {
                    return "y";
                }
                else if (input == "X")
                {
                    return "Y";
                }
                else
                {
                    return input;
                }
            }

            if (input[0] == 'x')
            {
                return $"y{ChangeXToY(input.Substring(1))}";
            }
            else if (input[0] == 'X')
            {
                return $"Y{ChangeXToY(input.Substring(1))}";
            }
            else
            {
                return $"{input[0]}{ChangeXToY(input.Substring(1))}";
            }
        }
    }
}
