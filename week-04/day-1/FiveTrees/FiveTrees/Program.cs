using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveTrees
{
    //Create 5 trees
    //Store the data of them in variables in your program
    //for every tree the program should store its'
    // type
    // leaf color
    // age
    // sex
    //you can use just variables, or lists and/or maps

    class Program
    {
        public struct Tree
        {
            string Type;
            string LeafColor;
            int Age;
            string Sex;
        }

        static void Main(string[] args)
        {
            Tree[] trees = new Tree[5];
            Console.ReadKey();
        }
    }
}
