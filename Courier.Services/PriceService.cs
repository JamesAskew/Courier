using System;
using Courier.Domain.Enums;
using Courier.Services.Interfaces;

namespace Courier.Services
{
    public class PriceService : IPriceService
    {
        public int GetPrice(ParcelSize parcelSize)
        {
            int price;
            switch (parcelSize)
            {
                case ParcelSize.Small:
                    price = 300;
                    break;
                case ParcelSize.Medium:
                    price = 800;
                    break;
                case ParcelSize.Large:
                    price = 1500;
                    break;
                case ParcelSize.ExtraLarge:
                    price = 2500;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(parcelSize), parcelSize, null);
            }

            return price;
        }
    }
}
