using System;
using System.Collections.Generic;
using System.Text;

namespace Courier.Domain.Models
{
    public class Parcel
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
    }
}
