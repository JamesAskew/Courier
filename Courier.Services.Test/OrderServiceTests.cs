using Courier.Domain.Enums;
using Courier.Domain.Models;
using System.Collections.Generic;
using Xunit;

namespace Courier.Services.Test
{
    public class OrderServiceTests
    {
        private readonly IOrderService _orderService;
        public OrderServiceTests()
        {
            this._orderService = new OrderService();
        }

        [Fact]
        public void GetTotalPriceForOrder_OfOneSmallPackage_Returns_300()
        {
            var prices = new List<Price>
            {
                new Price()
                {
                    Amount = 300,
                    Size = ParcelSize.Small
                }
            };

            var totalPrice = this._orderService.GetTotalPriceForOrder(prices);

            Assert.Equal(300, totalPrice);
        }
    }
}
