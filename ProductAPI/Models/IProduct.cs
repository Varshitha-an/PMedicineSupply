using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public interface IProduct<t>
    {
        public List<t> GetAllProducts();
    }
}
