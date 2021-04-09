using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AuthConsumer.Helpers
{
    public class Client : IClient
    {
        private readonly IConfiguration _config;
        public HttpClient client;
        public Client(IConfiguration config)
        {
            _config = config;
            client = new HttpClient();
        }
        public HttpClient GetAuthClient()
        {
            client.BaseAddress = new Uri(_config["Uri:Auth"]);
            return client;
        }
    }
}
