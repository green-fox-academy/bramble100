using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagram;


namespace Test
{
    [TestFixture]
    public class TestForFalse
    {
        Analyzer anagram = new Analyzer();

        [Test]
        public void ForOneEmptyStringAndOneNotEmpty() => Assert.AreEqual(false, anagram.IsAnagram(String.Empty, "hello"));

        [Test]
        public void ForTwoNotEmptyStrings() => Assert.AreEqual(false, anagram.IsAnagram("helo", "hello"));

        [Test]
        public void OneEmptyStringAndOneNotEmpty() => Assert.AreEqual(false, anagram.IsAnagram(String.Empty, "hello"));
    }

    [TestFixture]
    public class TestForTrue
    {
        Analyzer anagram = new Analyzer();
        // variations:
        // - empty string
        // - string with whitespace
        // - string with lowercase
        // - string with uppercase
        // - string with mixed case

        // variation for the two strings:
        // - same cases
        // - different cases in same letters
        // - different cases in different letters

        [Test]
        public void TwoEmptyStrings() => Assert.AreEqual(true, anagram.IsAnagram(String.Empty, String.Empty));

        [Test]
        public void TwoIdenticalStrings() => Assert.AreEqual(true, anagram.IsAnagram("hello", "hello"));

        [Test]
        public void AnagramsWithoutWhiteSpace() => Assert.AreEqual(true, anagram.IsAnagram("elhol", "hello"));

        [Test]
        public void AnagramsNoWhiteSpaceIdenticalMixedCase() => Assert.AreEqual(true, anagram.IsAnagram("elHol", "Hello"));

        [Test]
        public void AnagramsNoWhiteSpaceNotIdenticalMixedCase() => Assert.AreEqual(true, anagram.IsAnagram("elhOl", "Hello"));
    }
}
