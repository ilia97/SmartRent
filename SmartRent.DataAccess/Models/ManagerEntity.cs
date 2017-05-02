using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRent.DataAccess.Models
{
    public class ManagerEntity : UserData
    {
        [ForeignKey("Shop")]
        public int ShopId { get; set; }

        public ShopEntity Shop { get; set; }
    }
}