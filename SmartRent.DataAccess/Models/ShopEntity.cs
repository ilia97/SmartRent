using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRent.DataAccess.Models
{
    public class ShopEntity
    {
        public ShopEntity()
        {
            this.Managers = new List<ManagerEntity>();
            this.Items = new List<ItemEntity>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public double Longtitude { get; set; }
        
        public double Lattitude { get; set; }

        [ForeignKey("Admin")]
        public string AdminId { get; set; }

        public AdminEntity Admin { get; set; }

        public virtual List<ManagerEntity> Managers { get; set; }

        public virtual List<ItemEntity> Items { get; set; }
    }
}
