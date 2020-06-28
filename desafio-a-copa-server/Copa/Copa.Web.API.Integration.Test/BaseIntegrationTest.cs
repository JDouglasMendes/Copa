using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Copa.Web.API.Integration.Test
{
    public abstract class BaseIntegrationTest
    {
        protected TestServer Server { get; }
        protected HttpClient Client { get; }

        protected BaseIntegrationTest()
        {
            Server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());

            Client = Server.CreateClient();
        }
    }
}
