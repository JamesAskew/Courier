using Courier.Domain.Constants;
using Courier.Domain.Enums;
using Courier.Services.Interfaces;

namespace Courier.Services
{
    public class PriceService : IPriceService
    {
        public int GetPrice(ParcelSize parcelSize, int weight)
        {
            var basePrice = this.GetBasePrice(parcelSize);
            return IsOverWeight(parcelSize, weight) ? basePrice + CalculateOverWeightCharge(parcelSize, weight) : basePrice;
        }

        private int CalculateOverWeightCharge(ParcelSize parcelSize, int weight)
        {
            var limit = this.GetWeightLimit(parcelSize);
            var excess = weight - limit;

            return excess * WeightLimitFee.RegularFee;
        }

        private int GetBasePrice(ParcelSize parcelSize)
        {
            int price =0;
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
            }
            return price;
        }
        private int GetWeightLimit(ParcelSize parcelSize)
        {
            int maxWeight = 0;
            switch (parcelSize)
            {
                case ParcelSize.Small:
                    maxWeight = WeightLimit.Small;
                    break;
                case ParcelSize.Medium:
                    maxWeight = WeightLimit.Medium;
                    break;
                case ParcelSize.Large:
                    maxWeight = WeightLimit.Large;
                    break;
                case ParcelSize.ExtraLarge:
                    maxWeight = WeightLimit.ExtraLarge;
                    break;
            }
            return maxWeight;
        }
        private bool IsOverWeight(ParcelSize parcelSize, int weight)
        {
            return weight > this.GetWeightLimit(parcelSize);
        }
    }
}
