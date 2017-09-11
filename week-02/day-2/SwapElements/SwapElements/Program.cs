using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`

            string[] abc = new string[] { "first", "second", "third" };
            string temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;

            foreach( string s in abc)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();

        }
    }
}
