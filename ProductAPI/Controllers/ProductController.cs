using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProduct<Product> _repository;

        public ProductController(IProduct<Product> repository)
        {
            _repository = repository;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public ActionResult Get()
        {
            var products = _repository.GetAllProducts();
            if (products.Count() == 0)
                return BadRequest("No Products added till now");
            else
                return Ok(products);
        }
    }
}
