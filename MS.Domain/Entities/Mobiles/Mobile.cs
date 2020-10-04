using System;
using System.Collections.Generic;
using System.Text;

namespace MS.Domain.Entities
{
    public class Mobile
    {
        public Mobile()
        {
            Photos = new List<MobilePhoto>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Dimensions { get; set; }
        public string Weight { get; set; }
        public string ScreenSize { get; set; }
        public string Resolution { get; set; }
        public string Processor { get; set; }
        public string Memory { get; set; }
        public string OS { get; set; }
        public decimal Price { get; set; }
        public MobileVideo Video { get; set; }
        public List<MobilePhoto> Photos { get; set; }


    }
}
