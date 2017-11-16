using LagopusExam;
using LagopusExam.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using System.Net.Http;
using Xunit;

namespace LagopusExamIntegrationTests
{
    public class APIControllerShouldReturn
    {
        public HttpClient Client { get; set; }
        public TestServer Server;
        public DbContextOptions<LagopusExamContext> TestDBOptions;

        public APIControllerShouldReturn()
        {
            Server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            Client = Server.CreateClient();

            TestDBOptions = new DbContextOptionsBuilder<LagopusExamContext>()
                .UseInMemoryDatabase(databaseName: "LagopusExamTestDataBase")
                .Options;

        }
        [Fact]
        public async System.Threading.Tasks.Task ReturnOKWhenEmptyRouteAsync()
        {
            var response = await Client.GetAsync("/api");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
