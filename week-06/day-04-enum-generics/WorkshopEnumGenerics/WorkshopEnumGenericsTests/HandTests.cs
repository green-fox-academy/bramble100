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
            BlackJackHand hand = new BlackJackHand();
            hand.Add(new Card(Rank.Eight, Suit.Clubs));
            hand.Add(new Card(Rank.Eight, Suit.Diamonds));

            Assert.AreEqual(16, hand.Value);
        }

        [Test]
        public void Value_Under21_WithHighAce()
        {
            BlackJackHand hand = new BlackJackHand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));
            hand.Add(new Card(Rank.Eight, Suit.Diamonds));

            Assert.AreEqual(19, hand.Value);
        }

        [Test]
        public void Value_Under21_WithLowAce()
        {
            BlackJackHand hand = new BlackJackHand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));
            hand.Add(new Card(Rank.Eight, Suit.Clubs));
            hand.Add(new Card(Rank.Nine, Suit.Diamonds));

            Assert.AreEqual(18, hand.Value);
        }

        [Test]
        public void Value_Under21_WithTwoHighAces()
        {
            BlackJackHand hand = new BlackJackHand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));
            hand.Add(new Card(Rank.Eight, Suit.Clubs));
            hand.Add(new Card(Rank.Ace, Suit.Hearts));

            Assert.AreEqual(20, hand.Value);
        }

        [Test]
        public void Value_Under21_WithLowAndHighAces()
        {
            BlackJackHand hand = new BlackJackHand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));
            hand.Add(new Card(Rank.Two, Suit.Clubs));
            hand.Add(new Card(Rank.Seven, Suit.Clubs));
            hand.Add(new Card(Rank.Ace, Suit.Hearts));

            Assert.AreEqual(21, hand.Value);
        }

        [Test]
        public void Value_Under21_WithTwoLowAces()
        {
            BlackJackHand hand = new BlackJackHand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));
            hand.Add(new Card(Rank.Eight, Suit.Clubs));
            hand.Add(new Card(Rank.Nine, Suit.Diamonds));
            hand.Add(new Card(Rank.Ace, Suit.Hearts));

            Assert.AreEqual(19, hand.Value);
        }

        [Test]
        public void IsInGame()
        {
            BlackJackHand hand = new BlackJackHand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));

            Assert.True(hand.IsInGame);
        }

        [Test]
        public void TwentyOne()
        {
            BlackJackHand hand = new BlackJackHand();
            hand.Add(new Card(Rank.Ace, Suit.Clubs));
            hand.Add(new Card(Rank.Jack, Suit.Clubs));

            Assert.AreEqual(21, hand.Value);
        }

        [Test]
        public void ValueOver21()
        {
            BlackJackHand hand = new BlackJackHand();
            hand.Add(new Card(Rank.Jack, Suit.Clubs));
            hand.Add(new Card(Rank.Jack, Suit.Diamonds));
            hand.Add(new Card(Rank.Jack, Suit.Hearts));

            Assert.AreEqual(30, hand.Value);
        }

        [Test]
        public void IsBusted()
        {
            BlackJackHand hand = new BlackJackHand();
            hand.Add(new Card(Rank.Jack, Suit.Clubs));
            hand.Add(new Card(Rank.Jack, Suit.Diamonds));
            hand.Add(new Card(Rank.Jack, Suit.Hearts));

            Assert.AreEqual(30, hand.Value);
            Assert.True(hand.IsBusted);
        }

        [Test]
        public void Value_AfterUpdate()
        {
            BlackJackHand hand = new BlackJackHand();
            hand.Add(new Card(Rank.Two, Suit.Clubs));

            Assert.AreEqual(2, hand.Value);

            hand.Add(new Card(Rank.Three, Suit.Clubs));

            Assert.AreEqual(5, hand.Value);
        }
    }
}