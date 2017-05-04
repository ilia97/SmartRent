using System.Web.Mvc;

namespace SmartRent.AdminSite.Models.Shop
{
    public class ShopListItemViewModel
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
    }
}
