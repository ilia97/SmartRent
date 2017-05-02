using System.Collections.Generic;

namespace SmartRent.Core.Models
{
    public class Shop
    {
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

        public Admin Admin { get; set; }

        public List<Manager> Managers { get; set; }

        public List<Item> Items { get; set; }
    }
}