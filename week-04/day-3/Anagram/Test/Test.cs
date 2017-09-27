using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagram;


namespace Test
{

    // variations:
    // - empty string (ES)
    // - string with whitespace (WS)
    // - string with lowercase (LC)
    // - string with uppercase (UC)
    // - string with mixed case (MC)

    // variation for the two strings:
    // - same cases (SC)
    // - different cases in same letters(DCSL)
    // - different cases in different letters (DCDL)

    [TestFixture]
    public class TestForFalse
    {
        Analyzer anagram = new Analyzer();

        [Test]
        public void OneEmptyStringAndOneNotEmpty() => Assert.AreEqual(false, anagram.IsAnagram(String.Empty, "hello"));

        [Test]
        public void TwoNotEmptyStrings() => Assert.AreEqual(false, anagram.IsAnagram("helo", "hello"));

        [Test]
        public void TwoNotEmptyStringsEqualLength() => Assert.AreEqual(false, anagram.IsAnagram("helxo", "hello"));
    }

    [TestFixture]
    public class TestForTrue
    {
        Analyzer anagram = new Analyzer();

        // ES - ES
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

        [Test]
        public void AnagramsWhiteSpace() => Assert.AreEqual(true, anagram.IsAnagram("e lhOl", "Hell o"));
    }
}
