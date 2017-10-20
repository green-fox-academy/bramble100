using System;
using NUnit.Framework;
using WorkshopEnumGenerics.TwentyPlusOne;

namespace WorkshopEnumGenericsTests
{
    [TestFixture]
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
        public void ValueHighAce()
        {
            Rank rank = Rank.Ace;
            Suit suit = (Suit)random.Next(typeof(Suit).GetEnumNames().Length);

            Card card = new Card(rank, suit);
            Assert.True(card.IsHighAce);
            Assert.AreEqual(11, card.Value);
        }

        [Test]
        public void ValueLowAce()
        {
            Rank rank = Rank.Ace;
            Suit suit = (Suit)random.Next(typeof(Suit).GetEnumNames().Length);

            Card card = new Card(rank, suit);
            card.IsHighAce = false;
            Assert.False(card.IsHighAce);
            Assert.AreEqual(1, card.Value);
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
