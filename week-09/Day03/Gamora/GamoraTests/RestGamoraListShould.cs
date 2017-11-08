using Gamora;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GamoraIntegrationTests
{
    public class RestGamoraListShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestGamoraListShould()
        {
            Server = new TestServer(
                new WebHostBuilder()
                .UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatusWhenEmptyRoute()
        {
            var response = await Client.GetAsync("/");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusWhenAwesomeRoute()
        {
            var response = await Client.GetAsync("/awesome");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
