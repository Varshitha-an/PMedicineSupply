using AuthorizationProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<User> users = users = new List<User>();
        private ITokenGenerate _tokenGenerate;
        public UserController(ITokenGenerate tokenGenerate)
        {
            
            _tokenGenerate = tokenGenerate;
        }

        [HttpPost("register")]
        public ActionResult<User> Register(UserDTO userDTO)
        {
            using var hmac = new HMACSHA512();

            var user = new User
            {
                Username = userDTO.Username,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password)),
                PasswordSalt = hmac.Key
            };
            users.Add(user);
            return Ok("User Registered Succesfully");

        }

        [HttpPost("login")]
        public ActionResult<TokenUserDTO> Login(UserDTO userDTO)
        {
            var myUser = users.SingleOrDefault(usr => usr.Username == userDTO.Username);
          
            if (myUser!=null)
            {
                using var hmac = new HMACSHA512(myUser.PasswordSalt);
                var checkPasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password));
                for (int i = 0; i < checkPasswordHash.Length; i++)
                {
                    if (checkPasswordHash[i] != myUser.PasswordHash[i])
                        return Unauthorized("Invalid Password");
                }
                //return myUser;

                var tokenUser = new TokenUserDTO
                {
                    Username = myUser.Username,
                    Token = _tokenGenerate.CreateToken(myUser)

                };
                return tokenUser;
            }
            else
                return Unauthorized("Username does not exist");
            


        }

    }
}
