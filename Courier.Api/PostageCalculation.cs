using Courier.Domain.Models;
using Courier.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courier.Api
{
    public class PostageCalculation
    {
        private readonly ISizeService _sizeService;
        private readonly IPriceService _priceService;
        private readonly IOrderService _orderService;

        public PostageCalculation(ISizeService sizeService, IPriceService priceService, IOrderService orderService)
        {
            this._sizeService = sizeService;
            this._priceService = priceService;
            this._orderService = orderService;
        }

        public Order CalculateOrder(List<Parcel> parcels)
        {
            var prices = new List<Price>();

            foreach (var parcel in parcels)
            {
                var size = this._sizeService.GetParcelSize(parcel);
                var price = this._priceService.GetPrice(size);

                prices.Add(new Price
                {
                    Size = size,
                    Amount = price
                });
            }

            var orderTotal = this._orderService.GetTotalPriceForOrder(prices);

            var order = new Order
            {
                Prices = prices,
                TotalCost = orderTotal,
                SpeedyShippingCost = orderTotal * 2
            };

            return order;
        }
    }
}
