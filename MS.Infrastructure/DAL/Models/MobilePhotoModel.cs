using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MS.Infrastructure.DAL.Models
{
    public class MobilePhotoModel
    {
        [Key]
        public int ID { get; set; }
        public string Link { get; set; }
        public int MobileID { get; set; }
        public MobileModel Mobile { get; set; }
    }
}