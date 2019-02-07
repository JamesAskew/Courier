using Courier.Domain.Enums;

namespace Courier.Services.Interfaces
{
    public interface IPriceService
    {
        int GetPrice(ParcelSize parcelSize, int weight);
    }
}
