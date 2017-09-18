using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlsFromHandles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a list of GitHub handles as input and returns a list of strings that represents
            // GitHub url's under Green Fox Academy organization in the following format: "https://github.com/greenfox-academy/teststudent"

            // example:
            // input: ["ghhandle1", "ghhandle2"]
            // output: ["https://github.com/greenfox-academy/ghhandle1", "https://github.com/greenfox-academy/ghhandle2"]
            List<string> gitHubUrls = UrlsFromHandles(new List<string> { "ghhandle1", "ghhandle2" });
            Console.ReadKey();
        }

        private static List<string> UrlsFromHandles(List<string> list)
        {
            List<string> result = new List<string>();
            foreach (string gitHandle in list)
            {
                result.Add($"https://github.com/greenfox-academy/{gitHandle}");
            }
            return result;
        }
    }
}
