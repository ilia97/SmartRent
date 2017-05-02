using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SmartRent.Core.Models
{
    public class UserData : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
