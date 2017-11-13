using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxAirlines.Collections
{
    public static class GitHubHandlesAlpaga
    {
        private static readonly HashSet<string> handles = new HashSet<string>()
        {
            "adriennzakar",
            "AlbertBach",
            "bkorbuly",
            "bpo106",
            "bramble100",
            "CarrotTheHero",
            "csibivili",
            "CsKriszta93",
            "evelinhlacsok",
            "floraballabas",
            "garamreka",
            "gbotond",
            "GyMarek",
            "HerrNorbert",
            "kondfox",
            "kovacsnorb",
            "leventekobor94",
            "moodytea",
            "Suviii",
            "totger",
            "trojanosall",
            "truupi",
            "vargacsilla",
            "wangliqin123"
        };

        /// <summary>
        /// Returns true if given handle exists in the preset handle collection.
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        public static bool Contains(string handle) 
            => handles.Contains(handle);
    }
}
