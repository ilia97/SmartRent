using System.Collections.Generic;

namespace SmartRent.Core.Models
{
    public class Customer : UserData
    {
        public List<Rent> Rents { get; set; }
    }
}