using System.Collections.Generic;

namespace SmartRent.Core.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string ChipId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Prepayment { get; set; }

        public int PricePerDay { get; set; }

        public Shop Shop { get; set; }

        public List<Rent> Rents { get; set; }
    }
}