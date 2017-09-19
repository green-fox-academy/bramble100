using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt
            string path = @"./duplicated-chars.txt";
            foreach (string line in DecryptFile(path))
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }

        private static string[] DecryptFile(string path)
        {
            string[] fileContent = { };
            List<string> decryptedText = new List<string>();
            try
            {
                fileContent = File.ReadAllLines(path);
            }
            catch (IOException)
            {
                Console.WriteLine("Read error");
            }

            foreach (string line in fileContent)
            {
                string decryptedLine = "";
                for (int i = 0; i < line.Length; i+=2)
                {
                    decryptedLine += line[i];
                }
                decryptedText.Add(decryptedLine);
            }
            return decryptedText.ToArray<string>();
        }
    }
}
