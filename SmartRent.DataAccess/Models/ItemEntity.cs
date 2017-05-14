using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRent.DataAccess.Models
{
    public class ItemEntity
    {
        public ItemEntity()
        {
            this.Rents = new List<RentEntity>();
        }

        [Key]
        public int Id { get; set; }
        
        public string ChipId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Prepayment { get; set; }

        public int PricePerDay { get; set; }

        [ForeignKey("Shop")]
        public int ShopId { get; set; }

        public ShopEntity Shop { get; set;  }

        public virtual List<RentEntity> Rents { get; set; }
    }
}