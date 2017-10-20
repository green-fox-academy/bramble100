using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void ToStringMethod()
        {
            Rank rank = (Rank)random.Next(typeof(Rank).GetEnumNames().Length);
            Suit suit = (Suit)random.Next(typeof(Suit).GetEnumNames().Length);

            Card card = new Card(rank, suit);

            Assert.AreEqual($"{rank} of {suit}", card.ToString());
        }
    }
}
