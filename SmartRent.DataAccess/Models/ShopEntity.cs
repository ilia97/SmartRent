using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRent.DataAccess.Models
{
    public class ShopEntity
    {
        public ShopEntity()
        {
            this.Managers = new List<UserEntity>();
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

        public UserEntity Admin { get; set; }

        public virtual List<UserEntity> Managers { get; set; }

        public virtual List<ItemEntity> Items { get; set; }
    }
}
