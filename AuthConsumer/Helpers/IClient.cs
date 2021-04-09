using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AuthConsumer.Helpers
{
   public interface IClient
    {
        public HttpClient GetAuthClient();
    }
}
