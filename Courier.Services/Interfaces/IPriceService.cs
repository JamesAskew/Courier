using System;
using System.Collections.Generic;
using System.Text;
using Courier.Domain.Enums;
using Courier.Domain.Models;

namespace Courier.Services.Interfaces
{
    public interface IPriceService
    {
        int GetPrice(ParcelSize parcelSize);
    }
}
