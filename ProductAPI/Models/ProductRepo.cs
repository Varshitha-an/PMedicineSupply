using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class ProductRepo:IProduct<Product>
    {
        List<Product> products;

        public ProductRepo()
        {
            products = new List<Product>();
            products.Add(new Product
            {
                ProductId = 101,
                ProductName = "Samsung M31",
                Status = true,
                Price = 9000,
                Stock = 500,
                Description = "A Mobile",
                CountryofOrigin = "South Korea"

            });
            products.Add(new Product
            {
                ProductId = 102,
                ProductName = "Apple Iphone 12 pro",
                Status = true,
                Price = 119000,
                Stock = 500,
                Description = "A Mobile",
                CountryofOrigin = "USA"

            });

        }

        public List<Product> GetAllProducts()
        {
            return this.products;
        }
    }
}
