using Courier.Domain.Models;
using System.Collections.Generic;

namespace Courier.Services
{
    public interface IOrderService
    {
        int GetTotalPriceForOrder(IEnumerable<Price> prices);
    }
}
