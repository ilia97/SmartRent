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

        /// <summary>
        /// Долгота
        /// </summary>
        public int Longtitude { get; set; }

        /// <summary>
        /// Широта
        /// </summary>
        public int Lattitude { get; set; }

        [ForeignKey("Admin")]
        public string AdminId { get; set; }

        public AdminEntity Admin { get; set; }

        public virtual List<ManagerEntity> Managers { get; set; }

        public virtual List<ItemEntity> Items { get; set; }
    }
}
