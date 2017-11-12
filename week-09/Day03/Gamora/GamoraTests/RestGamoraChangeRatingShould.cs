using Gamora;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Newtonsoft.Json.Serialization;

// https://msdn.microsoft.com/en-us/library/system.web.script.serialization.javascriptserializer.aspx

namespace GamoraIntegrationTests
{
    public class RestGamoraChangeRatingShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestGamoraChangeRatingShould()
        {
            Server = new TestServer(
                new WebHostBuilder()
                .UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatusWhenNoIDGiven()
        {
            var response = await Client.GetAsync("/changerating");

            var expectedResult3 = JsonConvert.SerializeObject(new { error = "Please provide an ID" });

            Assert.Equal(HttpStatusCode.OK, 
                response.StatusCode);
            Assert.Equal(expectedResult3,
                await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task ReturnOkStatusWhenTooLowRatingGiven()
        {
            var response = await Client.GetAsync("/changerating/1/0");
            var expectedResult = new JsonResult(
                new { error = "Please provide a valid rating, at least 1" });

            Assert.Equal(HttpStatusCode.OK,
                response.StatusCode);
            Assert.Equal(expectedResult.Value,
                await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task ReturnOkStatusWhenTooHighRatingGiven()
        {
            var response = await Client.GetAsync("/changerating/1/6");
            var expectedResult = new JsonResult(
                new ErrorMessage() {
                    error = "Please provide a valid rating, not more than 5" });

            Assert.Equal(HttpStatusCode.OK,
                response.StatusCode);
            Assert.Equal(expectedResult.Value,
                await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task ReturnOkStatusWhenAwesomeRoute()
        {
            var response = await Client.GetAsync("/awesome");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }


    }
    class ErrorMessage
    {
        public string error { get; set; }
    }

}
