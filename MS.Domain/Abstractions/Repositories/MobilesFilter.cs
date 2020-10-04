using System;
using System.Collections.Generic;
using System.Text;

namespace MS.Domain.Abstractions.Repositories
{
    public class MobilesFilter
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int? PriceFrom { get; set; }
        public int? PriceTo { get; set; }
        public int Page { get; set; }

    }
}
