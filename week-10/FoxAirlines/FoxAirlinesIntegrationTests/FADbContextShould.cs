using FoxAirlines;
using FoxAirlines.Entities;
using FoxAirlines.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace FoxAirlinesIntegrationTests
{
    public class FADbContextShould
    {
        const string TEST_DESTINATION = "Test";
        readonly DateTime TEST_DATE = DateTime.Now.Date;

        public HttpClient Client { get; set; }
        public TestServer Server;
        public DbContextOptions<FoxAirlinesContext> TestDBOptions;

        public FADbContextShould()
        {
            Server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            Client = Server.CreateClient();

            TestDBOptions = new DbContextOptionsBuilder<FoxAirlinesContext>()
                .UseInMemoryDatabase(databaseName: "FoxAirlinesTestDataBase")
                .Options;
        }

        [Fact]
        public async Task ReturnOKStatusWhenEmptyRouteAsync()
        {
            var response = await Client.GetAsync("/api");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnEmptyJSonWhenEmptyRouteAsync()
        {
            string receivedJsonResult;

            var TestFlightTicket = new FlightTicket()
            {
                TakeOffDate = TEST_DATE,
                Destination = TEST_DESTINATION
            };

            using (var TestDBContext = new FoxAirlinesContext(TestDBOptions))
            {
                TestDBContext.AddNewFlightTicket(TEST_DATE, TEST_DESTINATION);

                receivedJsonResult = JsonConvert.SerializeObject(await TestDBContext
                   .FlightTickets
                   .FirstOrDefaultAsync(ticket
                   => ticket.TakeOffDate.Equals(TEST_DATE)
                   && ticket.Destination.Equals(TEST_DESTINATION)));

                //var response = await Client.GetAsync("/api");
                //var responseString = await response.Content.ReadAsStringAsync();
            }
            Assert.Equal(TestFlightTicket, JsonConvert.DeserializeObject<FlightTicket>(receivedJsonResult));        }
        }
    }
