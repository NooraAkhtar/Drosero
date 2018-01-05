using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Drosero.Domain.Models
{
    public class Customer
    {
        public string Name { get; set; }

        public string Mobile { get; set; }

        public int Count { get; set; }

        public DateTime ReservationDate { get; set; }
        public int Id { get; set; }
    }
}