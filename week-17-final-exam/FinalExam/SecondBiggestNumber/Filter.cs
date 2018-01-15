using System.Collections.Generic;
using System.Linq;

namespace SecondBiggestNumber
{
    public static class Filter
    {
        // 20.
        // Create a function that takes a list of numbers and returns the second biggest element from it.
        // https://github.com/greenfox-academy/final-exam-mini-exercises#20

        public static int SecondBiggestNumberMethod(IEnumerable<int> collection) => collection.OrderByDescending(x => x).ElementAt(1);
    }
}
