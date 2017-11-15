using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagopusExam.Collections
{
    public static class PredefinedQA
    {
        public static readonly Dictionary<string, string> QA = new Dictionary<string, string>()
        {
            { "When did your course start? (yyyy.mm.dd)", "2017.03.13"},
            { "What type of dog Barbi has?", "Whippet" },
            { "What is HerrNorbert's favourite color?", "Green" },
            { "How many classes are learning at Green Fox Academy at this moment?", "4" },
            { "How many mentors teach at Green Fox at this moment?", "16" },
            { "What was the name of the first Green Fox class?", "Vulpes" },
            { "How many likes do we have on facebook?", "~3300" },
            { "What is Tojas's horoscope?","Libra" }
        };
    }
}
