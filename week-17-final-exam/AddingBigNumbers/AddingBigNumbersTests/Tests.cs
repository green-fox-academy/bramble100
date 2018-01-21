using NUnit.Framework;
using AddingBigNumbers;

namespace AddingBigNumbersTests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("", 1, new int[] { 0 })]
        [TestCase("456", 6, new int[] { 6, 5, 4, 0, 0, 0 })]
        [TestCase("7894", 10, new int[] { 4, 9, 8, 7, 0, 0, 0, 0, 0, 0 })]
        public void ZeroPaddedArrayTest(string numberString, int length, int[] result)
        {
            Assert.AreEqual(result, Program.ZeroPaddedArray(numberString, length));
        }

        [TestCase(new int[] { 6, 5, 4, 0, 0, 0 }, new int[] { 0, 0, 0, 4, 5, 6 })]
        public void ReversedArrayTest(int[] inputArray, int[] resultArray)
        {
            Assert.AreEqual(resultArray, Program.ReversedArray(inputArray));
        }

        [TestCase("", "", "")]
        [TestCase("5", "5", "10")]
        [TestCase("5", "", "5")]
        [TestCase("5", "5", "10")]
        [TestCase("999", "", "999")]
        [TestCase("999", "999", "1998")]
        [TestCase("99999", "999", "100998")]
        [TestCase("2121212121212121212121212121212121212121212121212121212121212121",
            "555555",
            "02121212121212121212121212121212121212121212121212121212121767676")]
        [TestCase("99999999999999999999999999999999999999999999999999",
            "99999999999999999999999999999999999999999999999999",
            "199999999999999999999999999999999999999999999999998")]
        public void Test(string number1, string number2, string result)
        {
            Assert.AreEqual(result, Program.AddStrings(number1, number2));
        }
    }
}
