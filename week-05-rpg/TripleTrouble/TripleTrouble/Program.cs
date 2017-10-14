using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleTrouble
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        public class Kata
        {
            public static int TripleDouble(long num1, long num2)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (Convert.ToString(num1).Contains(new string(Convert.ToChar(i), 3)) &&
                        Convert.ToString(num2).Contains(new string(Convert.ToChar(i), 2)))
                        {
                        return 1;
                    }
                }
                return 0;
            }
        }
    }
}