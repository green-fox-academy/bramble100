using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LetterCounter;

namespace UnitTest
{
    [TestFixture]
    public class MainTest
    {

        [TestCase]
        public void True()
        {
            Dictionary<char, int> expectedResult = new Dictionary<char, int>() {
                { 'A', 4 },
                { 'B', 2 },
                { 'T', 1 }
            };
            Assert.AreEqual(expectedResult, Engine.Counter("AAAABBT"));
        }
    }
}
