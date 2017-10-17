using System;
using NUnit.Framework;
using Poker;

namespace PokerTest
{
    [TestFixture]
    public class PokerHandTests
    {
        PokerHand pokerHand;
        Random random = new Random();

        [Test]
        public void WhenNullInput()
        {
            string input = null;
            pokerHand = new PokerHand(input);
            Assert.IsFalse(pokerHand.IsValid);
        }
    }
}
