using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Poker;

namespace PokerTest
{
    [TestFixture]
    public class PokerHandTest
    {
        PlayingCard playingCard;

        [Test]
        public void WhenNullInput()
        {
            string input = null;
            playingCard = new PlayingCard(input);
            Assert.IsFalse(playingCard.IsValid);
        }

        [Test]
        public void WhenEmptyInput()
        {
            string input = string.Empty;
            playingCard = new PlayingCard(input);
            Assert.IsFalse(playingCard.IsValid);
        }
    }
}
