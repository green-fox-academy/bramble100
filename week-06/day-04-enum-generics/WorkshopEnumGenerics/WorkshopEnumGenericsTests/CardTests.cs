using System;
using NUnit.Framework;
using WorkshopEnumGenerics.TwentyPlusOne;

namespace WorkshopEnumGenericsTests
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

        [Test]
        public void ValueNoAce()
        {
            Rank rank = Rank.Nine;
            Suit suit = (Suit)random.Next(typeof(Suit).GetEnumNames().Length);

            Card card = new Card(rank, suit);

            Assert.AreEqual(9, card.Value);
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