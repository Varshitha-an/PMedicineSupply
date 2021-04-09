using AuthService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.Providers
{
    public interface IUserProvider
    {
        public string Login(User userCred);
        public string GenerateJWT(User userCred);
    }
}
