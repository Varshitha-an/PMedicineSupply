using AuthConsumer.Helpers;
using AuthConsumer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AuthConsumer.Providers
{
    public class UserProvider : IUserProvider
    {
        private readonly HttpClient _httpClient;
        public UserProvider(IClient authClient)
        {
            _httpClient = authClient.GetAuthClient();
        }
        public async Task<HttpResponseMessage> Login(User userCred)
        {
            try
            {
                var httpClient = new HttpClient();
                StringContent content = new StringContent(JsonConvert.SerializeObject(userCred), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("api/User", content);
                return response;
            }
            catch(Exception e)
            {
                throw;
            }
        }
    }
}
