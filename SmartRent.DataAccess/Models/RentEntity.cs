using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRent.DataAccess.Models
{
    public class RentEntity
    {
        [Key]
        public int Id { get; set; }

        public int Prepayment { get; set; }

        public int PricePerDay { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [ForeignKey("Item")]
        public int ItemId { get; set; }

        public ItemEntity Item { get; set; }

        [ForeignKey("Customer")]
        public string CustomerId { get; set; }

        public CustomerEntity Customer { get; set; }
    }
}