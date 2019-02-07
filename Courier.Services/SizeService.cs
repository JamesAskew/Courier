using Courier.Domain.Constants;
using Courier.Domain.Enums;
using Courier.Domain.Models;

namespace Courier.Services
{
    public class SizeService : ISizeService
    {
        public ParcelSize GetParcelSize(Parcel parcel)
        {
            if (parcel.Length > Dimension.Large ||
                parcel.Width > Dimension.Large ||
                parcel.Depth > Dimension.Large)
            {
                return ParcelSize.ExtraLarge;
            }

            if (parcel.Length >= Dimension.Medium && parcel.Length < Dimension.Large ||
                parcel.Width >= Dimension.Medium && parcel.Width < Dimension.Large ||
                parcel.Depth >= Dimension.Medium && parcel.Depth < Dimension.Large)
            {
                return ParcelSize.Large;
            }

            if (parcel.Length >= Dimension.Small && parcel.Length < Dimension.Medium ||
                parcel.Width >= Dimension.Small && parcel.Width < Dimension.Medium ||
                parcel.Depth >= Dimension.Small && parcel.Depth < Dimension.Medium)
            {
                return ParcelSize.Medium;
            }

            if (parcel.Length < Dimension.Small && parcel.Width < Dimension.Small && parcel.Depth < Dimension.Small)
            {
                return ParcelSize.Small;
            }

            return ParcelSize.ExtraLarge;
        }
    }
}
