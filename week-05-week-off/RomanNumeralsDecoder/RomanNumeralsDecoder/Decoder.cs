using System.Collections.Generic;

namespace RomanNumeralsDecoder
{
    public class Decoder
    {
        public static int RomanToDecimal(string roman)
        {
            int result = 0;
            Dictionary<char, int> romanNumbers = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            Stack<char> romanStack = new Stack<char>(roman);

            while (romanStack.Count > 0)
            {
                result += romanNumbers[romanStack.Pop()];
                if (result > 300)
                {
                    romanNumbers['C'] = -100;
                }
                else if (result>30)
                {
                    romanNumbers['X'] = -10;
                }
                else if (result>3)
                {
                    romanNumbers['I'] = -1;
                }
            }

            return result;
        }
    }
}
