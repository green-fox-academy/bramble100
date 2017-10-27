using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.GameServer;
using NUnit.Framework;

namespace BlackJackTests
{
    [TestFixture, TestOf("Card")]
    public class CardTests
    {
        Random random = new Random();

        [Test]
        public void Constructor()
        {
            Rank rank = (Rank)random.Next(typeof(Rank).GetEnumNames().Length);
            Suit suit = (Suit)random.Next(typeof(Suit).GetEnumNames().Length);

            Card card = new Card(rank, suit);

            Assert.AreEqual(rank, card.Rank);
            Assert.AreEqual(suit, card.Suit);
        }

        [TestCase(Rank.Two, 2)]
        [TestCase(Rank.Three, 3)]
        [TestCase(Rank.Four, 4)]
        [TestCase(Rank.Five, 5)]
        [TestCase(Rank.Six, 6)]
        [TestCase(Rank.Seven, 7)]
        [TestCase(Rank.Eight, 8)]
        [TestCase(Rank.Nine, 9)]
        [TestCase(Rank.Ten, 10)]
        [TestCase(Rank.Jack, 10)]
        [TestCase(Rank.Queen, 10)]
        [TestCase(Rank.King, 10)]
        [TestCase(Rank.Ace, 11)]
        public void Value(Rank rank, int value)
        {
            Suit suit = (Suit)random.Next(typeof(Suit)
                .GetEnumNames().Length);
            Card card = new Card(rank, suit);
            Assert.AreEqual(value, card.Value);
        }

        [Test]
        public void ToStringMethod()
        {
            Rank rank = (Rank)random.Next(typeof(Rank).GetEnumNames().Length);
            Suit suit = (Suit)random.Next(typeof(Suit).GetEnumNames().Length);

            Card card = new Card(rank, suit);

            Assert.AreEqual($"{rank} of {suit}", card.ToString());
        }
    }
}
