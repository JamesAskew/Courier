using System;
using System.Collections.Generic;
using System.Text;

namespace Courier.Domain.Enums
{
    [Flags]
    public enum ParcelSize
    {
        Small,
        Medium,
        Large,
        ExtraLarge
    }
}
