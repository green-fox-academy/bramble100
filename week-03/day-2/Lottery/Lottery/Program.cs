using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that find the 5 most common lottery numbers otos.csv
            string path = @"./otos.csv";
            foreach (int number in LotteryData(path))
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();

        }

        private static IEnumerable<int> LotteryData(string path)
        {

            string[] fileContent = LoadFromFile(path);
            Dictionary<int, int> winningNumbers = WinningNumbersFromFile(fileContent);
            List<int> topWinningNumbers = TopWinningNumbers(winningNumbers);
            return new List<int>();
        }

        private static List<int> TopWinningNumbers(Dictionary<int, int> winningNumbers)
        {
            //Dictionary<int, int> topWinningNumbers = winningNumbers.OrderByDescending<int,int>(x => x.Value).Take(5);
            foreach (int winningNumber in winningNumbers.Keys)
            {

            }
            return new List<int>();
        }

        private static Dictionary<int, int> WinningNumbersFromFile(string[] fileContent)
        {
            Dictionary<int, int> winningNumbers = new Dictionary<int, int>();

            int winningNumber;
            string[] processedLine = new string[16];
            foreach (string line in fileContent)
            {
                processedLine = line.Split(';');
                for (int i = 11; i < 16; i++)
                {
                    winningNumber = Int32.Parse(processedLine[i].ToString());
                    if (winningNumbers.ContainsKey(winningNumber))
                    {
                        winningNumbers[winningNumber]++;
                    }
                    else
                    {
                        winningNumbers.Add(winningNumber, 1);
                    }
                }
            }
            return winningNumbers;
        }

        private static string[] LoadFromFile(string path)
        {
            string[] fileContent = { };
            try
            {
                fileContent = File.ReadAllLines(path);
            }
            catch (IOException)
            {
                Console.WriteLine("Read error");
            }
            return fileContent;
        }
    }
}
