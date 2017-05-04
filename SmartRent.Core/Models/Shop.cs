using System.Collections.Generic;

namespace SmartRent.Core.Models
{
    public class Shop
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public double Longtitude { get; set; }
        
        public double Lattitude { get; set; }

        public User Admin { get; set; }

        public List<User> Managers { get; set; }

        public List<Item> Items { get; set; }
    }
}