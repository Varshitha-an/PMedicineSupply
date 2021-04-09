using AuthConsumer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AuthConsumer.Controllers
{
    public class ProductController : Controller
    {
        private string _token;

        //public async Task<ActionResult> Index1()
        //{


        //    HttpClient client = new HttpClient();
        //    string uri = "http://localhost:2167/product";
        //    var myResponse = await client.GetAsync(uri);
        //    if (myResponse.StatusCode == HttpStatusCode.OK)
        //    {
        //        var productsRaw = myResponse.Content.ReadAsAsync<List<Product>>();
        //        var products = productsRaw.Result;
        //        return View(products);
        //    }
        //    return View();
        //}
        public async Task<ActionResult> Index1()
        {
            try
            {

                if (HttpContext.Session.GetString("token") == null)
                {
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    
                    _token = HttpContext.Session.GetString("token");
                    HttpClient client = new HttpClient();
                    string uri = "http://localhost:40041/api/product";
                    var myResponse = await client.GetAsync(uri);
                    if (myResponse.IsSuccessStatusCode)
                    {
                        var productsRaw = myResponse.Content.ReadAsAsync<List<Product>>();
                        var products = productsRaw.Result;
                        return View(products);
                    }
                    return View();
                }


            }
            catch (Exception e)
            {
                return View("Error1");
            }

        }
    }
}
