using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SmartRent.Core.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Shop Shop { get; set; }

        public List<Rent> Rents { get; set; }

        public List<Shop> Shops { get; set; }
    }
}
