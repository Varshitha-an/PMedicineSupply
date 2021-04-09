using AuthConsumer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AuthConsumer.Providers
{
    public interface IUserProvider
    {
        public Task<HttpResponseMessage> Login(User userCred);
    }
}
