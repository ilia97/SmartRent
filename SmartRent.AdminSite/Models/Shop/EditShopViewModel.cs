using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using SmartRent.Core.Models;

namespace SmartRent.AdminSite.Models.Shop
{
    public class EditShopViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public double Longtitude { get; set; }

        public double Lattitude { get; set; }

        public List<Manager> Managers { get; set; }

        public List<Item> Items { get; set; }
    }
}
