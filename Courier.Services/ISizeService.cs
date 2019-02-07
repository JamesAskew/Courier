using Courier.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Courier.Domain.Models;

namespace Courier.Services
{
    public interface ISizeService
    {
        ParcelSize GetParcelSize(Parcel parcel);
    }
}
