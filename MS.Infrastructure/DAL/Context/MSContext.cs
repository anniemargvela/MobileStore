using Microsoft.EntityFrameworkCore;
using MS.Domain.Entities;
using MS.Infrastructure.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MS.Infrastructure.DAL.Context
{
    public class MSContext : DbContext
    {
        public MSContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MobileModel> Mobiles { get; set; }
        public DbSet<MobileVideoModel> Videos { get; set; }
        public DbSet<MobilePhotoModel> Photos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MobileModel>().HasData(
                new MobileModel
                {
                    ID = 1,
                    Name = "Iphone 11 pro",
                    Manufacturer = "Apple",
                    OS = "IOS",
                    Price = 3500,
                    Dimensions = "144mm X 71.4mm X 8.1mm",
                    Processor = "hexa-core Apple A13",
                    Resolution = "2436 x 1125",
                    ScreenSize = "5.8 inch",
                    Weight = "188g",
                    Memory = "4GB"
                },
                new MobileModel
                {
                    ID = 2,
                    Name = "Iphone 7",
                    Manufacturer = "Apple",
                    OS = "IOS",
                    Price = 1800,
                    Dimensions = "144mm X 71.4mm X 8.1mm",
                    Processor = "hexa-core Apple A9",
                    Resolution = "2436 x 1125",
                    ScreenSize = "4.7 inch",
                    Weight = "159g",
                    Memory = "3GB"
                },
                new MobileModel
                {
                    ID = 3,
                    Name = "Galaxy s20",
                    Manufacturer = "Samsung",
                    OS = "Android",
                    Price = 3500,
                    Dimensions = "144mm X 71.4mm X 8.1mm",
                    Processor = "Snapdragon 855",
                    Resolution = "2436 x 1125",
                    ScreenSize = "6.1 inch",
                    Weight = "188g",
                    Memory = "6GB"
                },
                new MobileModel
                {
                    ID = 4,
                    Name = "Galaxy s4",
                    Manufacturer = "Samsung",
                    OS = "Android",
                    Price = 1234,
                    Dimensions = "144mm X 71.4mm X 8.1mm",
                    Processor = "Snapdragon 650",
                    Resolution = "1200 x 850",
                    ScreenSize = "5.0 inch",
                    Weight = "145g",
                    Memory = "3GB"
                },
                new MobileModel
                {
                    ID = 5,
                    Name = "Honor 4c",
                    Manufacturer = "Huawei",
                    OS = "Android",
                    Price = 500,
                    Dimensions = "130mm X 65.4mm X 7.3mm",
                    Processor = "Snapdragon 550",
                    Resolution = "1800 x 850",
                    ScreenSize = "4.7 inch",
                    Weight = "130g",
                    Memory = "2GB"
                },
                new MobileModel
                {
                    ID = 6,
                    Name = "P30",
                    Manufacturer = "Huawei",
                    OS = "Android",
                    Price = 900,
                    Dimensions = "144mm X 71.4mm X 8.1mm",
                    Processor = "Snapdragon 855",
                    Resolution = "2436 x 1125",
                    ScreenSize = "5.7 inch",
                    Weight = "175g",
                    Memory = "4GB"
                },
                new MobileModel
                {
                    ID = 7,
                    Name = "Iphone SE",
                    Manufacturer = "Apple",
                    OS = "IOS",
                    Price = 1500,
                    Dimensions = "130mm X 65.5mm X 8.1mm",
                    Processor = "hexa-core Apple A12",
                    Resolution = "1900 x 900",
                    ScreenSize = "4.7 inch",
                    Weight = "160g",
                    Memory = "3GB"
                },
                new MobileModel
                {
                    ID = 8,
                    Name = "Galaxy A80",
                    Manufacturer = "Samsung",
                    OS = "Android",
                    Price = 1700,
                    Dimensions = "144mm X 71.4mm X 8.1mm",
                    Processor = "Snapdragon 855",
                    Resolution = "2436 x 1125",
                    ScreenSize = "6.0 inch",
                    Weight = "188g",
                    Memory = "4GB"
                },
                new MobileModel
                {
                    ID = 9,
                    Name = "Redmi note 9",
                    Manufacturer = "Xiaomi",
                    OS = "Android",
                    Price = 1499,
                    Dimensions = "162.3mm X 77.2mm X 8.9mm",
                    Processor = "MediaTek Helio G85",
                    Resolution = "1080 x 2340",
                    ScreenSize = "6.53 inch",
                    Weight = "199g",
                    Memory = "4GB"
                },
                new MobileModel
                {
                    ID = 10,
                    Name = "Lumia 1020",
                    Manufacturer = "Nokia",
                    OS = "Windows Phone",
                    Price = 120,
                    Dimensions = "144mm X 71.4mm X 8.1mm",
                    Processor = "Snapdragon S4 Plus",
                    Resolution = "1280 x 768",
                    ScreenSize = "4.5 inch",
                    Weight = "158g",
                    Memory = "32GB 2GB RAM"
                });
            modelBuilder.Entity<MobileVideoModel>().HasData(
                new MobileVideoModel
                {
                    ID = 1,
                    MobileID = 1,
                    Link = "https://www.youtube.com/watch?v=OoY7zp8GkLI&ab_channel=MarquesBrownlee"
                },
                new MobileVideoModel
                {
                    ID = 2,
                    MobileID = 2,
                    Link = "https://www.youtube.com/watch?v=nxf41fMX_Y4&ab_channel=MarquesBrownlee"
                },
                new MobileVideoModel
                {
                    ID = 3,
                    MobileID = 3,
                    Link = "https://www.youtube.com/watch?v=ZdC9soHxVC8&ab_channel=MarquesBrownlee"
                },
                new MobileVideoModel
                {
                    ID = 4,
                    MobileID = 4,
                    Link = "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy"
                },
                new MobileVideoModel
                {
                    ID = 5,
                    MobileID = 5,
                    Link = "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy"
                },
                new MobileVideoModel
                {
                    ID = 6,
                    MobileID = 6,
                    Link = "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy"
                },
                new MobileVideoModel
                {
                    ID = 7,
                    MobileID = 7,
                    Link = "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy"
                },
                new MobileVideoModel
                {
                    ID = 8,
                    MobileID = 8,
                    Link = "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy"
                },
                new MobileVideoModel
                {
                    ID = 9,
                    MobileID = 9,
                    Link = "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy"
                },
                new MobileVideoModel
                {
                    ID = 10,
                    MobileID = 10,
                    Link = "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy"
                });

            modelBuilder.Entity<MobilePhotoModel>().HasData(
                new MobilePhotoModel
                {
                    ID = 1,
                    MobileID = 1,
                    Link = "https://fdn2.gsmarena.com/vv/pics/apple/apple-iphone-11-pro-max-4.jpg"
                },
                new MobilePhotoModel
                {
                    ID = 11,
                    MobileID = 1,
                    Link = "https://fdn2.gsmarena.com/vv/bigpic/apple-iphone-11-pro-max-.jpg"
                },
                new MobilePhotoModel
                {
                    ID = 2,
                    MobileID = 2,
                    Link = "https://fdn2.gsmarena.com/vv/pics/apple/apple-iphone-7-3.jpg"
                },
                new MobilePhotoModel
                {
                    ID = 3,
                    MobileID = 3,
                    Link = "https://fdn2.gsmarena.com/vv/bigpic/samsung-galaxy-s20-ultra-.jpg"
                },
                new MobilePhotoModel
                {
                    ID = 4,
                    MobileID = 4,
                    Link = "https://fdn2.gsmarena.com/vv/bigpic/samsung-galaxy-s-4-i9500-black-mist.jpg"
                },
                new MobilePhotoModel
                {
                    ID = 5,
                    MobileID = 5,
                    Link = "https://fdn2.gsmarena.com/vv/pics/huawei/huawei-honor-4c-1.jpg"
                },
                new MobilePhotoModel
                {
                    ID = 6,
                    MobileID = 6,
                    Link = "https://fdn2.gsmarena.com/vv/pics/huawei/huawei-p30-1.jpg"
                },
                new MobilePhotoModel
                {
                    ID = 7,
                    MobileID = 7,
                    Link = "https://fdn2.gsmarena.com/vv/bigpic/apple-iphone-se-2020.jpg"
                },
                new MobilePhotoModel
                {
                    ID = 8,
                    MobileID = 8,
                    Link = "https://fdn2.gsmarena.com/vv/bigpic/samsung-galaxy-a80-.jpg"
                },
                new MobilePhotoModel
                {
                    ID = 9,
                    MobileID = 9,
                    Link = "https://fdn2.gsmarena.com/vv/pics/xiaomi/xiaomi-redmi-note-9-4.jpg"
                },
                new MobilePhotoModel
                {
                    ID = 10,
                    MobileID = 10,
                    Link = "https://fdn2.gsmarena.com/vv/pics/nokia/nokia-lumia-1020.jpg"
                });
        }

    }
}
