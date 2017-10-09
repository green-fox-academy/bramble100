using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CondiCipher;

namespace CondiCipherTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Encode1()
        {
            Assert.AreEqual("jx", Kata.Encode("cryptogam", "on", 10));
        }

        [Test]
        public void Encode2()
        {
            Assert.AreEqual("cytgmdfmbk", 
                Kata.Encode("cryptogam", "cryptogram", 0));
        }

        [Test]
        public void Encode3()
        {
            Assert.AreEqual("jx wnz xrkvz jnd l ufd vwcz.", 
                Kata.Encode("cryptogam", "on the first day i got lost.", 10));
        }

        [Test]
        public void Encode4()
        {
            Assert.AreEqual("n ggka cvssb bfe esz omgdyr bqqva", 
                Kata.Encode("superkey", "i will never eat any grapes again", 4));
        }

        [Test]
        public void Decode1()
        {
            Assert.AreEqual("on", Kata.Decode("jx", "cryptogam", 10));
        }
        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual("....", Kata.Decode("....", "cryptogam", 10));
            Assert.AreEqual("sit", Kata.Decode("abc", "keykeykeykey", 10));
            Assert.AreEqual(",sit", Kata.Decode(",abc", "keykeykeykey", 10));
            Assert.AreEqual("on the first day i got lost.", Kata.Decode("jx wnz xrkvz jnd l ufd vwcz.", "cryptogam", 10));
            Assert.AreEqual("i will never eat any grapes again", Kata.Decode("n ggka cvssb bfe esz omgdyr bqqva", "superkey", 30));
            Assert.AreEqual("zva nguhbmmgydx.s,ok se,rmafz vpedgbua", Kata.Decode("qvf cmnxmdkjfca.p,ab mf,byokf vjhwpcyb", "nqhbfgmi", 28));
        }
    }
}
