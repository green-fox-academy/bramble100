using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    public class Reservation : IReservationy
    {
        private string ID;
        private string dayOfWeek;
        private const string availableCharsForID = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private string[] daysOfWeek = new string[]
        {
            "MON",
            "TUE",
            "WED",
            "THU",
            "FRI",
            "SAT",
            "SUN"
        };
        private Random random = new Random();
        private const int IDLength = 8;

        public string IReservationy.CodeBooking()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < IDLength; i++)
            {
                stringBuilder.Append(availableCharsForID[random.Next(availableCharsForID.Length)]);
            }
            return stringBuilder.ToString();
        }

        public string IReservationy.GetDowBooking()
        {
            return daysOfWeek[random.Next(daysOfWeek.Length)];
        }
    }
}
