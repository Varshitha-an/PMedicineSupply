using AuthConsumer.Models;
using AuthConsumer.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AuthConsumer.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserProvider _userProvider;
        public UserController(IUserProvider userProvider)
        {
            _userProvider = userProvider;
        }
        public IActionResult Index()
        {
            try
            {
                if(HttpContext.Session.GetString("token")==null)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    return View();
                }
            }
           catch (Exception e)
            {
                return View("Error1");
            }
        }

        public IActionResult Login()
        {
            try
            {
                if (HttpContext.Session.GetString("token") != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                return View("Error1");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(User userCredentials)
        {
            try
            {
                HttpResponseMessage response = await _userProvider.Login(userCredentials);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    GetJWT token = JsonConvert.DeserializeObject<GetJWT>(result);
                    HttpContext.Session.SetString("token", token.Token);
                    HttpContext.Session.SetString("userName", userCredentials.UserName);
                    ViewBag.UserName = userCredentials.UserName;
                    return RedirectToAction("Index");
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    ViewBag.Info = "Invalid UserName/Password. Please check again";
                    return View();
                }
                else
                {
                    return View("Error1");
                }
            }
            catch (Exception e)
            {
                return View("Error1");
            }
        }
            public IActionResult Logout()
            {
                try
                {
                    HttpContext.Session.Remove("token");
                    HttpContext.Session.Remove("userName");
                    return View();
                }
                catch (Exception e)
                {
                    return View("Error1");
                }
            }
    }
}

