using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MS.Infrastructure.DAL.Models
{
    public class MobileModel
    {
        [Key]
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
        public virtual ICollection<MobileVideoModel> Videos { get; set; }
        public virtual ICollection<MobilePhotoModel> Photos { get; set; }

    }
}
