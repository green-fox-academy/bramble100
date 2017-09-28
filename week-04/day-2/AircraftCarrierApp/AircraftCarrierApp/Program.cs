using System;

namespace AircraftCarrierApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Carrier[] carriers = new Carrier[2];
            carriers[0] = new Carrier(300, 1000);
            carriers[1] = new Carrier(300, 1000);

            for (int i = 0; i < random.Next(6,10); i++)
            {
                carriers[0].AddAircraft(random.Next(1,3)>1? 
                    AircraftType.F35: 
                    AircraftType.F16);
            }

            for (int i = 0; i < random.Next(6, 10); i++)
            {
                carriers[1].AddAircraft(random.Next(1, 3) > 1 ? 
                    AircraftType.F35 : 
                    AircraftType.F16);
            }

            carriers[0].Reload();
            carriers[1].Reload();
            Console.WriteLine(carriers[0].ToString());
            Console.WriteLine(carriers[1].ToString());

            carriers[0].Fight(carriers[1]);
            Console.WriteLine(carriers[0].ToString());

            Console.ReadKey();
        }
    }
}
