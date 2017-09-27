using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SumTest
{
    [TestFixture]
    class TestForMySum
    {
        [TestCase]
        public void ListWithOneElement()
        {
            Assert.AreEqual(7, MySum.Sum(new List<int>() { 7 }));
        }

        [TestCase]
        public void ListWithTwoElement()
        {
            Assert.AreEqual(7, MySum.Sum(new List<int>() { 1, 6 }));
        }

        [TestCase]
        public void ListWithNegative()
        {
            Assert.AreEqual(8, MySum.Sum(new List<int>() { -1, 9 }));
        }

        [TestCase]
        public void EmptyList()
        {
            Assert.AreEqual(0, MySum.Sum(new List<int>() { }));
        }

        [TestCase]
        [Expected]
        public void Null()
        {
            Assert.AreEqual(0, MySum.Sum(null));
        }
    }
}
