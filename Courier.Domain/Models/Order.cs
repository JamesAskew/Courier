using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Courier.Domain.Models
{
    public class Order
    {
        public IEnumerable<Price> Prices { get; set; }
        public int TotalCost { get; set; }
    }
}
