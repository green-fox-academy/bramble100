using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesTest
{
    [TestFixture]
    class TestForApples
    {
        Apples apple = new Apples();

        [TestCase]
        public void AppleString()
        {
            Assert.AreEqual("apple", apple.GetApple());
        }

    }
}
