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
    public class RestGamoraHomeControllerShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestGamoraHomeControllerShould()
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
        public async Task ReturnOkStatusWhenShowRoute()
        {
            var response = await Client.GetAsync("/show");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusWhenShow()
        {
            var response = await Client.GetAsync("/show");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
