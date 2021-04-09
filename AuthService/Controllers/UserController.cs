using AuthService.Models;
using AuthService.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserProvider _userProvider;
        public UserController(IUserProvider userProvider)
        {
            _userProvider = userProvider;
        }

        [HttpPost]
        public ActionResult Login(User userCred)
        {
            try
            {
                string token = _userProvider.Login(userCred);
                if(token!=null)
                {
                    return Ok(new { token });
                }
                else
                {
                    return NotFound("Invalid UserName/Password");
                }
            }
            catch(Exception e)
            {
                return BadRequest();
            }
        }
    }
}
