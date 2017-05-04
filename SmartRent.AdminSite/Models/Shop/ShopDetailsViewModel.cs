using System.Collections.Generic;
using System.Web.Mvc;
using SmartRent.Core.Models;

namespace SmartRent.AdminSite.Models.Shop
{
    public class ShopDetailsViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Долгота
        /// </summary>
        public double Longtitude { get; set; }

        /// <summary>
        /// Широта
        /// </summary>
        public double Lattitude { get; set; }

        public List<User> Managers { get; set; }

        public List<Item> Items { get; set; }
    }
}
