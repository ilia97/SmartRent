using System;

namespace SmartRent.Core.Models
{
    public class Rent
    {
        public int Id { get; set; }

        public int Prepayment { get; set; }

        public int PricePerDay { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Item Item { get; set; }

        public Customer Customer { get; set; }
    }
}