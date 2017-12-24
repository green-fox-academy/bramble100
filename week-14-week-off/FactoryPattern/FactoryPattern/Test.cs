using System;
using NUnit.Framework;

namespace FactoryPattern
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Factory.Creator<String>());
        }

        [Test]
        public void ReturnsInteger()
        {
            var result = Factory.Creator<int>();
            Assert.IsInstanceOf<int>(result);
        }

        [Test]
        public void ReturnsDouble()
        {
            var result = Factory.Creator<double>();
            Assert.IsInstanceOf<double>(result);
        }

        [Test]
        public void ReturnsMyClass()
        {
            var result = Factory.Creator<MyClass>();
            Assert.IsInstanceOf<MyClass>(result);
        }
    }
}
