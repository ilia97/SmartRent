using System.Collections.Generic;

namespace SmartRent.DataAccess.Models
{
    public class AdminEntity : UserData
    {
        public AdminEntity() : base()
        {
            this.Shops = new List<ShopEntity>();
        }

        public virtual List<ShopEntity> Shops { get; set; }
    }
}