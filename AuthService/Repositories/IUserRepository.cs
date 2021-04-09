using AuthService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.Repositories
{
    public interface IUserRepository
    {
        public UserDTO GetUser(User user);
    }
}
