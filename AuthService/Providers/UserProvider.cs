using AuthService.Models;
using AuthService.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Providers
{
    public class UserProvider : IUserProvider
    {
        private readonly IConfiguration _config;
        private readonly IUserRepository _userRepo;
        public UserProvider(IUserRepository userRepo,IConfiguration config)
        {
            _userRepo = userRepo;
            _config = config;
        }
        public string GenerateJWT(User userCred)
        {
            try
            {
                UserDTO user = _userRepo.GetUser(userCred);
                if(user!=null)
                {
                    var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["jwt:Key"]));
                    var credentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _config["Jwt:Issuer"],
                         _config["Jwt:Issuer"],
                         null,
                         expires: DateTime.Now.AddMinutes(30),
                         signingCredentials: credentials);
                    return new JwtSecurityTokenHandler().WriteToken(token);
                }
                else
                {
                    return null;
                }
           
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public string Login(User userCred)
        {
            User user = new User();
            UserDTO userDTO;
            try
            {
                userDTO = _userRepo.GetUser(userCred);
                string token = null;
                if(userDTO!=null)
                {
                    user.UserName = userDTO.UserName;
                    token = GenerateJWT(userCred);
                }
                return token;
            }
            catch(Exception e)
            {
                throw;
            }

        }
    }
}
