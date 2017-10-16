using System.Linq;
using System.Text;

namespace Rot13
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string Rot13(string message)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] words = message.Split('-', '_');
            stringBuilder.Append(words[0]);
            for (int i = 1; i < words.Length; i++)
            {
                stringBuilder.Append($"{words[i].First().ToString().ToUpper()}{words[i].Substring(1)}");
            }
            return stringBuilder.ToString();
        }

    }
}
