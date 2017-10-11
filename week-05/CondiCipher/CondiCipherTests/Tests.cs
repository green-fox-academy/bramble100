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
            Assert.AreEqual("jx", Kata.Encode("on", "cryptogam", 10));
        }

        [Test]
        public void Encode2()
        {
            Assert.AreEqual("cytgmdfmbk", 
                Kata.Encode("cryptogram", "cryptogam", 0));
        }

        [Test]
        public void Encode3()
        {
            Assert.AreEqual("jx wnz xrkvz jnd l ufd vwcz.", 
                Kata.Encode("on the first day i got lost.", "cryptogam", 10));
        }

        [Test]
        public void Encode4()
        {
            Assert.AreEqual("n ggka cvssb bfe esz omgdyr bqqva", 
                Kata.Encode("i will never eat any grapes again", "superkey", 4));
        }

        [Test]
        public void Decode1()
        {
            Assert.AreEqual("on", Kata.Decode("jx", "cryptogam", 10));
        }

        [Test]
        public void Decode2()
        {
            Assert.AreEqual("....", Kata.Decode("....", "cryptogam", 10));
        }


        [Test]
        public void Decode3()
        {
            Assert.AreEqual("sit", Kata.Decode("abc", "keykeykeykey", 10));
        }

        [Test]
        public void Decode4()
        {
            Assert.AreEqual(",sit", Kata.Decode(",abc", "keykeykeykey", 10));
        }

        [Test]
        public void Decode5()
        {
            Assert.AreEqual("on the first day i got lost.", Kata.Decode("jx wnz xrkvz jnd l ufd vwcz.", "cryptogam", 10));
        }

        [Test]
        public void Decode6()
        {
            Assert.AreEqual("i will never eat any grapes again", Kata.Decode("n ggka cvssb bfe esz omgdyr bqqva", "superkey", 30));
        }

        [Test]
        public void Decode7()
        {
            Assert.AreEqual("zva nguhbmmgydx.s,ok se,rmafz vpedgbua", Kata.Decode("qvf cmnxmdkjfca.p,ab mf,byokf vjhwpcyb", "nqhbfgmi", 28));
        }
    }
}
