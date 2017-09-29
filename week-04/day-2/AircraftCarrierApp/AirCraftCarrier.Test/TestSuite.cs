using NUnit.Framework;
using System;
using AircraftCarrierApp;
using AirCraftCarrier;
using System.Collections;

namespace AirCraftCarrier.Test
{
    [TestFixture]
    public class TestSuite
    {
        Carrier carrier = new Carrier(1000, 1000);


        [TestCase]
        public void NoRefillableAircraft()
        {
            Type type = typeof(AirCraftF16);
            Assert.AreEqual(false, carrier.ThereIsAircraftToReload(type));
        }
    }
}
