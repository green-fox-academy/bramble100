using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://en.wikipedia.org/wiki/List_of_monarchs_of_the_Netherlands

namespace SmartQueue
{
    public enum Country
    {
        ChuckNorris,
        British,
        Dutch
    }

    public class AllowedMonarchs : HashSet<string>
    {
        public AllowedMonarchs(Country country = Country.ChuckNorris)
        {
            Add("Chuck"); // Norris, of course
            if (country == Country.Dutch)
            {
                UnionWith(new HashSet<string>()
                {
                    "William-Alexander",
                    "Beatrix",
                    "Juliana",
                    "Wilhelmina",
                    "William III "
                });
            }
            else if (country == Country.British)
            {
                Add("Elizabeth II");
                Add("George VI");
                Add("Edward VIII");
                Add("George V");
                Add("Edward VII");
            }
        }
    }
}
