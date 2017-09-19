using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts reversed-lines.txt
            string path = @"./reversed-lines.txt";
            foreach (string line in DecryptFile(path))
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }


        private static string[] DecryptFile(string path)
        {
            string[] fileContent = { };
            List<string> reversedText = new List<string>();
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
                string reversedLine = "";
                if (line.Length>0)
                {
                    for (int i = line.Length - 1; i >= 0; i--)
                    {
                        reversedLine += line[i];
                    }
                }
                reversedText.Add(reversedLine);
            }
            return reversedText.ToArray<string>();
        }
    }
}
