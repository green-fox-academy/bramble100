using FoxAirlines;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace FoxAirlinesIntegrationTests
{
    public class FAShould
    {
        private TestServer Server;
        private HttpClient Client;

        public FAShould()
        {
            // Arrange
            Server = new TestServer(
            new WebHostBuilder()
                .UseStartup<Startup>());

            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOKWhenEmptyRoute()
        {
            // Act
            Assert.Equal(HttpStatusCode.OK, (await Client.GetAsync("")).StatusCode);
        }
    }
}
