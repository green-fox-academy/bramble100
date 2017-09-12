using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indention

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("My todo:");
            sb.Append(todoText);
            sb.AppendLine(" - Download games");
            sb.AppendLine("     - Diablo");

            todoText = sb.ToString();

            Console.WriteLine(todoText);
            Console.ReadKey();
        }
    }
}
