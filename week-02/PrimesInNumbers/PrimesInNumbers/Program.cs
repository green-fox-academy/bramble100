using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/primes-in-numbers/train/csharp
            // input: 7775460
            // output: "(2**2)(3**3)(5)(7)(11**2)(17)"

            for (int i = 1; i < 7775460; i++)
            {
                foreach (var item in PrimeDecomp.DividerFinder(i))
                {
                    Console.Write("{0} ", item);
                    
                }
            Console.WriteLine(PrimeDecomp.Dividers(i));
            }
            
            //PrimeDecomp.Dividers(2);
            //PrimeDecomp.Dividers(2);
            //PrimeDecomp.Dividers(7775460);
            Console.ReadKey();
        }

        public class PrimeDecomp
        {
            // output: "(2**2)(3**3)(5)(7)(11**2)(17)"

            public static String Dividers(int number)
            {
                return FormattedDividersString(DividerFinder(number));
            }

            public static string FormattedDividersString(List<int> list)
            {
                StringBuilder stringBuilder = new StringBuilder();

                if(list.Count == 0)
                {
                    return "";
                }
                while (list.Count>0)
                {
                    int previousDivider = list.First();
                    int dividerCounter = 1;
                    list.RemoveAt(0);
                    while (list.Count > 0)
                    {
                        if (list.First() == previousDivider)
                        {
                            list.RemoveAt(0);
                            dividerCounter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    stringBuilder.Append(String.Format("({0}**{1})", previousDivider, dividerCounter));
                }
                return stringBuilder.ToString();
            }

            public static List<int> DividerFinder(int number)
            {
                var resultList = new List<int>();
                int nextDivider;
                do
                {
                    nextDivider = FindNextDivider(number);
                    if (nextDivider != 0)
                    {
                        resultList.Add(nextDivider);
                        number /= nextDivider;
                    }
                } while (nextDivider > 0);                
                return resultList;
            }
            /// <summary>
            /// Returns the next divider.
            /// </summary>
            /// <param name="Number to divide."></param>
            /// <returns>The next divider</returns>
            private static int FindNextDivider(int number)
            {
                if (number < 2)
                {
                    return 0;
                }
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        return i;
                    }
                }
                return number;
            }
        }
    }
}
