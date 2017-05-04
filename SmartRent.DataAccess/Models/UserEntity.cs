using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRent.DataAccess.Models
{
    public class UserEntity : IdentityUser
    {
        public UserEntity() : base()
        {
            this.Shops = new List<ShopEntity>();
            this.Rents = new List<RentEntity>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual List<ShopEntity> Shops { get; set; }
        
        [ForeignKey("Shop")]
        public int? ShopId { get; set; }

        public ShopEntity Shop { get; set; }

        public List<RentEntity> Rents { get; set; }
    }
}
