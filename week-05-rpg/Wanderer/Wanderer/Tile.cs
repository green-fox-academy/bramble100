using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    public class Tile
    {
        private bool IsWalkable;

        public Tile(bool isWalkable)
        {
            IsWalkable = isWalkable;
        }
    }
}