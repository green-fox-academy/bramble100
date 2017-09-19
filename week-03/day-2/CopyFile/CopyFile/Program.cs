using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            string pathInto = @"./my-file-into.txt";
            string pathFrom = @"./my-file-from.txt";
            string success = WriteIntoFile(pathInto, ReadFromFile(pathFrom)) ? "successful" : "unsuccesful";
            Console.WriteLine($"Copy process was {success}");
            Console.ReadKey();
            
        }

        private static bool WriteIntoFile(string pathInto, string[] content)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(pathInto))
                {
                    foreach (string line in content)
                    {
                        writer.WriteLine(line);
                    }                    
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Write error");
                return false;
            }
            return true;
        }

        private static string[] ReadFromFile(string pathFrom)
        {
            string[] result = { };
            try
            {
                result = File.ReadAllLines(pathFrom);
            }
            catch (IOException)
            {
                Console.WriteLine("Read error");
            }
            return result;
        }
    }
}
