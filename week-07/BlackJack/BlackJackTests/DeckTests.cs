using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.GameServer;
using NUnit.Framework;

namespace BlackJackTests
{
    [TestFixture, TestOf("Deck")]
    class DeckTests
    {
        [Test]
        public void FirstCard()
        {
            Deck deck = new Deck();

            Assert.AreEqual(new Card(Rank.Two, Suit.Spades), deck.PullFirst());
        }

        [Test]
        public void LastCard()
        {
            Deck deck = new Deck();

            Assert.AreEqual(new Card(Rank.Ace, Suit.Hearts), deck.PullLast());
        }
    }
}
