using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts encoded-lines.txt
            string path = @"./encoded-lines.txt";
            foreach (string line in EncodeFile(path))
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }

        private static string[] EncodeFile(string path)
        {
            string[] fileContent = { };
            List<string> encodedText = new List<string>();
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
                string encodedLine = "";
                for (int i = 0; i < line.Length; i++)
                {
                    encodedLine += line[i] == ' ' ? ' ' : Convert.ToChar(line[i] - 1);
                }
                encodedText.Add(encodedLine);
            }
            return encodedText.ToArray<string>();
        }
    }
}
