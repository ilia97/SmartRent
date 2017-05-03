using System.ComponentModel.DataAnnotations;

namespace SmartRent.AdminSite.Models.Shop
{
    public class CreateShopViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }


        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        /// <summary>
        /// Долгота
        /// </summary>
        [Required]
        public double Longtitude { get; set; }

        /// <summary>
        /// Широта
        /// </summary>
        [Required]
        public double Lattitude { get; set; }
    }
}
