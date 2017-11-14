using Microsoft.EntityFrameworkCore;
using FoxAirlines.Entities;
//using FoxAirlinesIntegrationTests.TextFixtures;
using FoxAirlines.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace FoxAirlinesIntegrationTests.Scenarios
{
    [Collection("BaseCollection")]
    class FAAppDBShould
    {
        private FoxAirlineContext context;

        public FAAppDBShould(FoxAirlineContext context)
        {
            this.context = context;
        }

        [Fact]
        public async Task AddTicket()
        {
            var options = new DbContextOptionsBuilder<FoxAirlineContext>().
                UseInMemoryDatabase(databaseName: "TicketAddTestDb").Options;


            using (var DbContext = new FoxAirlineContext(options))
            {
                string expectedDestination = "Home";
                var FlightTicketRepository = new FoxAirlinesRepository(DbContext);
                DbContext.FlightTickets.Add(new FoxAirlines.Models.FlightTicket()
                {
                    TakeOffDate = DateTime.Now.Date,
                    Destination = expectedDestination
                });
                DbContext.SaveChanges();

                var ticket = await DbContext.FlightTickets.FirstOrDefaultAsync(p => p.Destination.Equals("Test"));
                Assert.Equal(expectedDestination, ticket.Destination);
            }
        }
    }
}
