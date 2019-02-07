using System;
using System.Collections.Generic;
using System.Text;
using Courier.Domain.Enums;

namespace Courier.Domain.Models
{
    public class Price
    {
        public ParcelSize Size { get; set; }
        public int Amount { get; set; }
    }
}
