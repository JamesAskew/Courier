using Courier.Domain.Models;
using Courier.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Courier.Api.Test
{
    public class PostageCalculationTests
    {

        private readonly PostageCalculation _postageCalculation;

        public PostageCalculationTests()
        {
            this._postageCalculation = new PostageCalculation(new SizeService(), new PriceService(), new OrderService());
        }

        [Fact]
        public void CalculateOrder_ForOneSmallPackage_Returns_TotalPrice_300()
        {
            var parcels = new List<Parcel>
            {
                new Parcel
                {
                    Length = 9,
                    Width = 9,
                    Depth = 9
                }
            };

            var order = this._postageCalculation.CalculateOrder(parcels);

            Assert.Equal(300, order.TotalCost);
        }

        [Fact]
        public void CalculateOrder_ForOnePackage_Returns_OnePriceObject()
        {
            var parcels = new List<Parcel>
            {
                new Parcel
                {
                    Length = 9,
                    Width = 9,
                    Depth = 9
                }
            };

            var order = this._postageCalculation.CalculateOrder(parcels);

            Assert.True(order.Prices.Count() == 1);
        }

        [Fact]
        public void CalculateOrder_ForOneMediumPackage_Returns_TotalPrice_800()
        {
            var parcels = new List<Parcel>
            {
                new Parcel
                {
                    Length = 12,
                    Width = 12,
                    Depth = 12
                }
            };

            var order = this._postageCalculation.CalculateOrder(parcels);

            Assert.Equal(800, order.TotalCost);
        }

        [Fact]
        public void CalculateOrder_ForSmallAndMediumPackage_Returns_TotalPrice_1100()
        {
            var parcels = new List<Parcel>
            {
                new Parcel
                {
                    Length = 9,
                    Width = 9,
                    Depth = 9
                }, new Parcel
                {
                    Length = 12,
                    Width = 12,
                    Depth = 12
                }
            };

            var order = this._postageCalculation.CalculateOrder(parcels);

            Assert.Equal(1100, order.TotalCost);
        }

        [Fact]
        public void CalculateOrder_ForOneSmallPackage_Returns_SpeedyShipping_600()
        {
            var parcels = new List<Parcel>
            {
                new Parcel
                {
                    Length = 9,
                    Width = 9,
                    Depth = 9
                }
            };

            var order = this._postageCalculation.CalculateOrder(parcels);

            Assert.Equal(600, order.SpeedyShippingCost);
        }

        [Fact]
        public void CalculateOrder_ForOneOverWeightSmallParcel_Returns_TotalPrice_10100()
        {
            var parcels = new List<Parcel>
            {
                new Parcel
                {
                    Length = 9,
                    Width = 9,
                    Depth = 9,
                    Weight = 50
                }
            };

            var order = this._postageCalculation.CalculateOrder(parcels);

            Assert.Equal(10100, order.TotalCost);
        }
    }
}
