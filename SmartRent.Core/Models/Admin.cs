using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRent.Core.Models
{
    public class Admin : UserData
    {
        public List<Shop> Shops { get; set; }
    }
}
