using AuthService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<UserDTO> Users = new List<UserDTO>()
        {
            new UserDTO(){UserID=1,UserName="Ram",Password="ram123"},
            new UserDTO(){UserID=2,UserName="Sam",Password="sam123"}
        };
        public UserDTO GetUser(User user)
        {
            try
            {
                UserDTO userDTO = Users.SingleOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);
                return userDTO;
            }
            catch(Exception e)
            {
                throw;
            }
        }
    }
}
