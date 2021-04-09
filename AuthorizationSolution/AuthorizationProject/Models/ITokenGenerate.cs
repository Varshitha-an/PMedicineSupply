using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationProject.Models
{
    public interface ITokenGenerate
    {
        public string CreateToken(User user);
    }
}
