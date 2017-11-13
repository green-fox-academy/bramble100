using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxAirlines.Collections
{
    public static class Airports
    {
        public static readonly HashSet<string> Names = new HashSet<string>()
        {
            "Berlin",
            "Bratislava",
            "Budapest",
            "Copenhagen",
            "Madrid",
            "Prague",
            "Wien"
        };

        public static HashSet<string> OtherAirports(string airport)
        {
            var result = Names;
            result.Remove(airport);
            return result;
        }
    }
}