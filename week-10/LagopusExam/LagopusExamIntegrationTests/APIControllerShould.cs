using LagopusExam;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using Xunit;

namespace LagopusExamIntegrationTests
{
    public class APIControllerShould
    {
        public HttpClient Client { get; set; }
        public TestServer Server;

        public APIControllerShould()
        {
            Server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async System.Threading.Tasks.Task ReturnOKWhenHttpGetQuestionsAsync()
        {
            var response = await Client.GetAsync("/questions");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
