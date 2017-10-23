using NUnit.Framework;
using WorkshopEnumGenerics.TwentyPlusOne;

namespace WorkshopEnumGenericsTests
{
    [TestFixture, TestOf("Hand")]
    class HandTests
    {
        [Test]
        public void Value_Under21_WithTwoEights()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Eight, Suit.Clubs));
            hand.Add(new Card(Rank.Eight, Suit.Diamonds));

            Assert.AreEqual(16, hand.Value);
        }

        [Test]
        public void Value_Under21_WithHighAce()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));
            hand.Add(new Card(Rank.Eight, Suit.Diamonds));

            Assert.AreEqual(19, hand.Value);
        }

        [Test]
        public void Value_Under21_WithLowAce()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));
            hand.Add(new Card(Rank.Eight, Suit.Clubs));
            hand.Add(new Card(Rank.Nine, Suit.Diamonds));

            Assert.AreEqual(18, hand.Value);
        }

        [Test]
        public void Value_Under21_WithTwoHighAces()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));
            hand.Add(new Card(Rank.Eight, Suit.Clubs));
            hand.Add(new Card(Rank.Ace, Suit.Hearts));

            Assert.AreEqual(20, hand.Value);
        }

        [Test]
        public void Value_Under21_WithLowAndHighAces()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));
            hand.Add(new Card(Rank.Two, Suit.Clubs));
            hand.Add(new Card(Rank.Seven, Suit.Clubs));
            hand.Add(new Card(Rank.Ace, Suit.Hearts));

            Assert.AreEqual(21, hand.Value);
        }

        [Test]
        public void Value_Under21_WithTwoLowAces()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));
            hand.Add(new Card(Rank.Eight, Suit.Clubs));
            hand.Add(new Card(Rank.Nine, Suit.Diamonds));
            hand.Add(new Card(Rank.Ace, Suit.Hearts));

            Assert.AreEqual(19, hand.Value);
        }

        [Test]
        public void IsInGame()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));

            Assert.True(hand.IsInGame);
        }

        [Test]
        public void TwentyOne()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));
            hand.Add(new Card(Rank.Jack, Suit.Clubs));

            Assert.AreEqual(21, hand.Value);
        }

        [Test]
        public void ValueOver21()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Jack, Suit.Clubs));
            hand.Add(new Card(Rank.Jack, Suit.Diamonds));
            hand.Add(new Card(Rank.Jack, Suit.Hearts));

            Assert.AreEqual(30, hand.Value);
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
        public void Value_AfterUpdate()
        {
            Hand hand = new Hand();
            hand.Add(new Card(Rank.Two, Suit.Clubs));

            Assert.AreEqual(2, hand.Value);

            hand.Add(new Card(Rank.Three, Suit.Clubs));

            Assert.AreEqual(5, hand.Value);
        }
    }
}