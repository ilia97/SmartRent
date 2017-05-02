using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace SmartRent.DataAccess.Models
{
    public class CustomerEntity : UserData
    {
        public CustomerEntity() : base()
        {
            this.Rents = new List<RentEntity>();
        }

        public List<RentEntity> Rents { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<CustomerEntity> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            return userIdentity;
        }
    }
}
