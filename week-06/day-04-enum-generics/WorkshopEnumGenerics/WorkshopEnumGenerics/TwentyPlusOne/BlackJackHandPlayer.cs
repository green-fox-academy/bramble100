using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    public class BlackJackHandPlayer : BlackJackHand
    {
        public bool IsImprovable => !IsBusted;

    }
}