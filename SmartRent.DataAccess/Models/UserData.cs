using Microsoft.AspNet.Identity.EntityFramework;

namespace SmartRent.DataAccess.Models
{
    public abstract class UserData : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
