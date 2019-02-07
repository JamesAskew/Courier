using System;
using Courier.Domain.Enums;
using Courier.Domain.Models;
using Xunit;

namespace Courier.Services.Test
{
    public class SizeServiceTests
    {
        private readonly ISizeService _sizeService;

        public SizeServiceTests()
        {
            this._sizeService = new SizeService();
        }

        [Fact]
        public void GetParcelSize_Returns_Small()
        {
            var parcel = new Parcel
            {
                Length = 9,
                Width = 9,
                Depth = 9
            };

            var parcelSize = this._sizeService.GetParcelSize(parcel);

            Assert.True(parcelSize == ParcelSize.Small);
        }

        [Fact]
        public void GetParcelSize_Returns_Medium()
        {
            var parcel = new Parcel
            {
                Length = 30,
                Width = 5,
                Depth = 5
            };

            var parcelSize = this._sizeService.GetParcelSize(parcel);

            Assert.True(parcelSize == ParcelSize.Medium);
        }

        [Fact]
        public void GetParcelSize_Returns_Large()
        {
            var parcel = new Parcel
            {
                Length = 50,
                Width = 50,
                Depth = 10
            };

            var parcelSize = this._sizeService.GetParcelSize(parcel);

            Assert.True(parcelSize == ParcelSize.Large);
        }

        [Fact]
        public void GetParcelSize_Returns_ExtraLarge()
        {
            var parcel = new Parcel
            {
                Length = 500,
                Width = 50,
                Depth = 50
            };

            var parcelSize = this._sizeService.GetParcelSize(parcel);

            Assert.True(parcelSize == ParcelSize.ExtraLarge);
        }
    }
}
