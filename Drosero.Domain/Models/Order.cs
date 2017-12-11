using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }

        public int FoodItemId { get; set; }

        public int UserId { get; set; }

        public int AddressId { get; set; }
    }
}
