using NUnit.Framework;
using WorkshopEnumGenerics.TwentyPlusOne;

namespace WorkshopEnumGenericsTests
{
    [TestFixture, TestOf("Hand")]
    class HandTests
    {
        [Test]
        public void ValueUnderBlackJackWithTwoEights()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Eight, Suit.Clubs));
            hand.Add(new Card(Rank.Eight, Suit.Diamonds));

            Assert.AreEqual(16, hand.Value);
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

        [Test]
        public void ValueAfterUpdate()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Two, Suit.Clubs));

            Assert.AreEqual(2, hand.Value);

            hand.Add(new Card(Rank.Three, Suit.Clubs));

            Assert.AreEqual(5, hand.Value);
        }
    }
}