using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Landmark { get; set; }

        public string City { get; set; }

        public string Pincode { get; set; }

        public string State { get; set; }

        public bool IsPrimaryAddress { get; set; }
    }
}
