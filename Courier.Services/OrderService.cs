using System;
using System.Collections.Generic;
using System.Text;
using Courier.Domain.Models;

namespace Courier.Services
{
    public class OrderService : IOrderService
    {
        public int GetTotalPriceForOrder(IEnumerable<Price> prices)
        {
            return 0;
        }
    }
}
