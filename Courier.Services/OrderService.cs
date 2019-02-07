using System.Collections.Generic;
using System.Linq;
using Courier.Domain.Models;
using Courier.Services.Interfaces;

namespace Courier.Services
{
    public class OrderService : IOrderService
    {
        public int GetTotalPriceForOrder(IEnumerable<Price> prices)
        {
            var totalPrice = 0;
            if (prices.Any())
            {
                totalPrice = prices.Sum(x => x.Amount);
            }
            return totalPrice;
        }
    }
}
