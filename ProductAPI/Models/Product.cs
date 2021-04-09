using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public bool Status { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public string CountryofOrigin { get; set; }
        public List<string> FeedBack { get; set; }
        public Product()
        {
            FeedBack = new List<string>();
        }
    }
}
