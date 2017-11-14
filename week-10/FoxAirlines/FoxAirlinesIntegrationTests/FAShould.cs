using FoxAirlines;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
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
            Server = new TestServer(
                new WebHostBuilder()
                .UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOKWhenEmptyRoute()
        {
            var response = await Client.GetAsync("");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
