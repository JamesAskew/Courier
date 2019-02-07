using Courier.Domain.Models;
using System.Collections.Generic;

namespace Courier.Services.Interfaces
{
    public interface IOrderService
    {
        int GetTotalPriceForOrder(IEnumerable<Price> prices);
    }
}
