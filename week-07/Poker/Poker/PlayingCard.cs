using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class PlayingCard
    {
        public char Rank { get; }
        public char Suit { get; }
        public bool IsValid { get; private set; }

        public PlayingCard(string inputString)
        {
            IsValid = (inputString != null);
        }
    }
}
