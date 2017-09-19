using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts reversed-lines.txt
            string path = @"./reversed-order.txt";
            foreach (string line in ReverseOrder(path))
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }

        private static string[] ReverseOrder(string path)
        {
            string[] fileContent = { };
            List<string> reverseOrderText = new List<string>();
            try
            {
                fileContent = File.ReadAllLines(path);
            }
            catch (IOException)
            {
                Console.WriteLine("Read error");
            }

            for (int i = fileContent.Length-1; i >= 0; i--)
            {
                reverseOrderText.Add(fileContent[i]);
            }
            return reverseOrderText.ToArray<string>();
        }

    }
}
