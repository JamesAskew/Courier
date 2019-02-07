using Courier.Domain.Enums;
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
            var price = this._priceService.GetPrice(ParcelSize.Small);

            Assert.Equal(300, price);
        }

        [Fact]
        public void GetMediumPackagePrice_Returns_800()
        {
            var price = this._priceService.GetPrice(ParcelSize.Medium);

            Assert.Equal(800, price);
        }

        [Fact]
        public void GetLargePackagePrice_Returns_1500()
        {
            var price = this._priceService.GetPrice(ParcelSize.Large);

            Assert.Equal(1500, price);
        }

        [Fact]
        public void GetExtraLargePackagePrice_Returns_2500()
        {
            var price = this._priceService.GetPrice(ParcelSize.ExtraLarge);

            Assert.Equal(2500, price);
        }

    }
}
