using System.Collections.Generic;

namespace Courier.Domain.Models
{
    public class Order
    {
        public IEnumerable<Price> Prices { get; set; }
        public int TotalCost { get; set; }
        public int SpeedyShippingCost { get; set; }
    }
}
