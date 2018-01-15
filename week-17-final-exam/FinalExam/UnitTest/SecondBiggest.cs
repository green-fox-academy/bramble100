using NUnit.Framework;
using System.Collections.Generic;
using System;
using SecondBiggestNumber;

namespace UnitTest
{
    [TestFixture]
    public class SecondBiggest
    {
        private readonly Random random = new Random();

        [Test]
        public void Error_EmptyCollection()
        {
            IEnumerable<int> initialCollection = new List<int>();
            Assert.Catch<ArgumentOutOfRangeException>(() => Filter.SecondBiggestNumberMethod(initialCollection));
        }

        [Test]
        public void Error_CollectionWithOneElements()
        {
            IEnumerable<int> initialCollection = new List<int>() { 1 };
            Assert.Catch<ArgumentOutOfRangeException>(() => Filter.SecondBiggestNumberMethod(initialCollection));
        }

        [Test]
        public void CollectionWithTwoElements()
        {
            IEnumerable<int> initialCollection = new List<int>() { 1, 2 };
            int expectedResult = 1;
            Assert.AreEqual(expectedResult, Filter.SecondBiggestNumberMethod(initialCollection));
        }

        [Test]
        public void CollectionWithThreeElements()
        {
            IEnumerable<int> initialCollection = new List<int>() { 2, -4, 7 };
            int expectedResult = 2;
            Assert.AreEqual(expectedResult, Filter.SecondBiggestNumberMethod(initialCollection));
        }

        [Test]
        public void CollectionWithFourElements()
        {
            IEnumerable<int> initialCollection = new List<int>() { -3562, -4345, 732, 95778 };
            int expectedResult = 732;
            Assert.AreEqual(expectedResult, Filter.SecondBiggestNumberMethod(initialCollection));
        }

        [Test]
        public void CollectionWithTenElements()
        {
            IEnumerable<int> initialCollection = new List<int>() { 2, -4, 7, 8, -5, 45654, -533, 7542, -23, 0 };
            int expectedResult = 7542;
            Assert.AreEqual(expectedResult, Filter.SecondBiggestNumberMethod(initialCollection));
        }

        [Test]
        public void CollectionWithTenMillionRandomElements()
        {
            int expectedResult = 7542;
            var initialCollection = new List<int>() { expectedResult };
            initialCollection.Add(random.Next(expectedResult, int.MaxValue));
            for (int i = 0; i < 9_999_998; i++)
            {
                initialCollection.Add(random.Next(int.MinValue, expectedResult));
            }
            Assert.AreEqual(10_000_000, initialCollection.Count);
            Assert.AreEqual(expectedResult, Filter.SecondBiggestNumberMethod(initialCollection));
        }
    }
}
