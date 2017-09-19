using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"
            string path = @"./my-file.txt";
            string[] content = { };
            try
            {
                content = File.ReadAllLines(path);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Uh-oh, could not read the file!");
            }
            foreach (string line in content)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }
    }
}
