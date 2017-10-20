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
    class HandTests
    {
        [Test]
        public void ValueUnderBlackJack()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));

            Assert.AreEqual(11, hand.Value);
        }

        [Test]
        public void IsInGame()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));

            Assert.True(hand.IsInGame);

        }

        [Test]
        public void BlackJack()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));
            hand.Add(new Card(Rank.Jack, Suit.Clubs));

            Assert.AreEqual(21, hand.Value);
            Assert.True(hand.IsBlackJack);
        }

        [Test]
        public void IsBusted()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Jack, Suit.Clubs));
            hand.Add(new Card(Rank.Jack, Suit.Diamonds));
            hand.Add(new Card(Rank.Jack, Suit.Hearts));

            Assert.AreEqual(30, hand.Value);
            Assert.True(hand.IsBusted);
        }

    }
}
