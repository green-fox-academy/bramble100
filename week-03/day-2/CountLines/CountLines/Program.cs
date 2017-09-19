using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            string path = @"./my-file.txt";
            Console.WriteLine(LineCounter(path));
            path = @"./my-fileGNDGNSGDS.txt";
            Console.WriteLine(LineCounter(path));
            Console.ReadKey();
        }

        static int LineCounter(string path)
        {
            string[] content = { };
            try
            {
                content = File.ReadAllLines(path);
            }
            catch (FileNotFoundException)
            {
                return 0;
            }
            return content.Length;
        }
    }
}
