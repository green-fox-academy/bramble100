using System;
using System.Diagnostics;
using System.Linq;

namespace PersistentBuggerRunner
{
    class Program
    {
        public delegate int methodsToExamine(long n);

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            long number = 999;

            methodsToExamine[] methods = new methodsToExamine[10]
            {
                Persist.Persistence1,
                Persist.Persistence2,
                Persist.Persistence3,
                Persist.Persistence4,
                Persist.Persistence5,
                Persist.Persistence6,
                Persist.Persistence7,
                Persist.Persistence8,
                Persist.Persistence9,
                Persist.Persistence10
            };
                

            TimeSpan[] timeSpans = new TimeSpan[9];

            foreach (var method in methods)
            {
                Console.WriteLine($"{number}: {method(number)}");
            }

            stopwatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                Persist.Persistence1(number);
            }
            stopwatch.Stop();
            Console.WriteLine($" 1: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                Persist.Persistence2(number);
            }
            stopwatch.Stop();
            Console.WriteLine($" 2: {stopwatch.Elapsed}");
            stopwatch.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                Persist.Persistence3(number);
            }
            stopwatch.Stop();
            Console.WriteLine($" 3: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                Persist.Persistence4(number);
            }
            stopwatch.Stop();
            Console.WriteLine($" 4: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                Persist.Persistence5(number);
            }
            stopwatch.Stop();
            Console.WriteLine($" 5: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                Persist.Persistence6(number);
            }
            stopwatch.Stop();
            Console.WriteLine($" 6: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                Persist.Persistence7(number);
            }
            stopwatch.Stop();
            Console.WriteLine($" 7: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                Persist.Persistence8(number);
            }
            stopwatch.Stop();
            Console.WriteLine($" 8: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                Persist.Persistence9(number);
            }
            stopwatch.Stop();
            Console.WriteLine($" 9: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                Persist.Persistence10(number);
            }
            stopwatch.Stop();
            Console.WriteLine($"10: {stopwatch.Elapsed}");

            Console.ReadKey();
        }

        public class Persist
        {
            // https://www.codewars.com/kata/persistent-bugger/train/csharp

            public static int Persistence1(long n)
            {
                int result = 0;
                string numberString = Convert.ToString(n);
                char[] numberArray = numberString.ToCharArray();
                while (numberArray.Length > 1)
                {
                    int temp = 1;
                    foreach (char digit in numberArray)
                    {
                        temp *= Convert.ToInt32(digit.ToString());
                    }
                    numberArray = Convert.ToString(temp).ToCharArray();
                    result++;
                }
                return result;
            }

            public static int Persistence2(long n)
            {
                int result = 0;
                char[] numberArray = Convert.ToString(n).ToCharArray();
                while (numberArray.Length > 1)
                {
                    int temp = 1;
                    foreach (char digit in numberArray)
                    {
                        temp *= Convert.ToInt32(digit.ToString());
                    }
                    numberArray = Convert.ToString(temp).ToCharArray();
                    result++;
                }
                return result;
            }

            public static int Persistence3(long n)
            {
                int result = 0;
                char[] numberArray;
                do
                {
                    numberArray = Convert.ToString(n).ToCharArray();
                    n = 1;
                    foreach (char digit in numberArray)
                    {
                        n *= Convert.ToInt32(digit.ToString());
                    }
                    result++;
                } while (numberArray.Length > 1);
                return result - 1;
            }

            public static int Persistence4(long n)
            {
                int result = 0;
                char[] numberArray;
                do
                {
                    numberArray = Convert.ToString(n).ToCharArray();
                    n = 1;
                    numberArray.ToList().ForEach(digit => n *= Convert.ToInt32(digit.ToString()));
                    result++;
                } while (numberArray.Length > 1);
                return result - 1;
            }

            public static int Persistence5(long n)
            {
                int result = 0;
                char[] numberArray = Convert.ToString(n).ToCharArray();
                while (numberArray.Length > 1)
                {
                    int temp = 1;
                    numberArray.ToList().ForEach(digit => temp *= Convert.ToInt32(digit.ToString()));
                    numberArray = Convert.ToString(temp).ToCharArray();
                    result++;
                }
                return result;
            }

            public static int Persistence6(long n)
            {
                int result = 0;
                int temp = 1;
                while (n > 9)
                {
                    Convert.ToString(n).ToCharArray().ToList().ForEach(digit => temp *= Convert.ToInt32(digit.ToString()));
                    n = temp;
                    result++;
                }
                return result;
            }

            public static int Persistence7(long n)
            {
                int result = 0;
                var numberList = Convert.ToString(n).ToList();
                while (numberList.Count > 1)
                {
                    int digitsMultiplied = 1;
                    numberList.ForEach(digit => digitsMultiplied *= Convert.ToInt32(digit.ToString()));
                    numberList = Convert.ToString(digitsMultiplied).ToList(); ;
                    result++;
                }
                return result;
            }

            public static int Persistence8(long n)
            {
                int result = 0;
                var numberList = Convert.ToString(n).ToList();
                while (numberList.Count > 1)
                {
                    int digitsMultiplied = 1;
                    numberList.ForEach(digit => digitsMultiplied *= (Convert.ToInt32(digit) - '0'));
                    numberList = Convert.ToString(digitsMultiplied).ToList(); ;
                    result++;
                }
                return result;
            }

            public static int Persistence9(long n)
            {
                int result = 0;
                var numberList = Convert.ToString(n).ToList();
                while (numberList.Count > 1)
                {
                    int digitsMultiplied = 1;
                    numberList.ForEach(digit => digitsMultiplied *= (Convert.ToInt32(digit) - '0'));
                    numberList = digitsMultiplied.ToString().ToList(); ;
                    result++;
                }
                return result;
            }

            public static int Persistence10(long n)
            {
                // not my own solution
                int count = 0;
                while (n > 9)
                {
                    count++;
                    n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
                }
                return count;
            }
        }
    }
}