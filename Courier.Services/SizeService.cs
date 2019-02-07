using System;
using System.Collections.Generic;
using System.Text;
using Courier.Domain.Constants;
using Courier.Domain.Enums;
using Courier.Domain.Models;

namespace Courier.Services
{
    public class SizeService : ISizeService
    {
        public ParcelSize GetParcelSize(Parcel parcel)
        {
            return ParcelSize.Small;            
        }
    }
}
