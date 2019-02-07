
using Courier.Domain.Enums;
using Courier.Domain.Models;
using Courier.Services.Interfaces;
using Xunit;

namespace Courier.Services.Test
{
    public class PriceServiceTests
    {
        private readonly IPriceService _priceService;

        public PriceServiceTests()
        {
            this._priceService = new PriceService();
        }

        [Fact]
        public void GetSmallPackagePrice_Returns_300()
        {
            var price = this._priceService.GetPrice(ParcelSize.Small, 1);

            Assert.Equal(300, price);
        }

        [Fact]
        public void GetMediumPackagePrice_Returns_800()
        {
            var price = this._priceService.GetPrice(ParcelSize.Medium, 3);

            Assert.Equal(800, price);
        }

        [Fact]
        public void GetLargePackagePrice_Returns_1500()
        {
            var price = this._priceService.GetPrice(ParcelSize.Large, 6);

            Assert.Equal(1500, price);
        }

        [Fact]
        public void GetExtraLargePackagePrice_Returns_2500()
        {
            var price = this._priceService.GetPrice(ParcelSize.ExtraLarge, 10);

            Assert.Equal(2500, price);
        }

        [Fact]
        public void GetOverWeightSmallParcelPrice_Returns_10100()
        {
            var price = this._priceService.GetPrice(ParcelSize.Small, 50);

            Assert.Equal(10100, price);
        }

        [Fact]
        public void GetOverWeightLargeParcelPrice_Returns_10300()
        {
            var price = this._priceService.GetPrice(ParcelSize.Large, 50);

            Assert.Equal(10300, price);
        }

        [Fact]
        public void GetOverWeightExtraLargeParcelPrice_Returns_10500()
        {
            var price = this._priceService.GetPrice(ParcelSize.ExtraLarge, 50);

            Assert.Equal(10500, price);
        }

        [Fact]
        public void GetPrice_ForOverHeavyParcel_Returns_5000()
        {
            var price = this._priceService.GetPrice(ParcelSize.Heavy, 49);

            Assert.Equal(5000, price);
        }

        [Fact]
        public void GetPrice_ForOverWeightHeavyParcel_Returns_10000()
        {
            var price = this._priceService.GetPrice(ParcelSize.Heavy, 100);

            Assert.Equal(10000, price);
        }
    }
}
