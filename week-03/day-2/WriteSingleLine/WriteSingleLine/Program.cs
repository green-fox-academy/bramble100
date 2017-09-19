using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"
            string path = @"./my-file.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                try
                {
                    writer.WriteLine("Arnold Barna is the fox!");
                }
                catch (IOException)
                {
                    Console.WriteLine("Unable to write file: my-file.txt"); ;
                }
            }
            Console.ReadKey();
        }
    }
}
