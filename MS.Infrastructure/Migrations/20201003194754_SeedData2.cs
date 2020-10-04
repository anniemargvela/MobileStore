using Microsoft.EntityFrameworkCore.Migrations;

namespace MS.Infrastructure.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mobiles",
                columns: new[] { "ID", "Dimensions", "Manufacturer", "Memory", "Name", "OS", "Price", "Processor", "Resolution", "ScreenSize", "Weight" },
                values: new object[,]
                {
                    { 4, "144mm X 71.4mm X 8.1mm", "Samsung", "3GB", "Galaxy s4", "Android", 1234m, "Snapdragon 650", "1200 x 850", "5.0 inch", "145g" },
                    { 5, "130mm X 65.4mm X 7.3mm", "Huawei", "2GB", "Honor 4c", "Android", 500m, "Snapdragon 550", "1800 x 850", "4.7 inch", "130g" },
                    { 6, "144mm X 71.4mm X 8.1mm", "Huawei", "4GB", "P30", "Android", 900m, "Snapdragon 855", "2436 x 1125", "5.7 inch", "175g" },
                    { 7, "130mm X 65.5mm X 8.1mm", "Apple", "3GB", "Iphone SE", "IOS", 1500m, "hexa-core Apple A12", "1900 x 900", "4.7 inch", "160g" },
                    { 8, "144mm X 71.4mm X 8.1mm", "Samsung", "4GB", "Galaxy A80", "Android", 1700m, "Snapdragon 855", "2436 x 1125", "6.0 inch", "188g" },
                    { 9, "162.3mm X 77.2mm X 8.9mm", "Xiaomi", "4GB", "Redmi note 9", "Android", 1499m, "MediaTek Helio G85", "1080 x 2340", "6.53 inch", "199g" },
                    { 10, "144mm X 71.4mm X 8.1mm", "Nokia", "32GB 2GB RAM", "Lumia 1020", "Windows Phone", 120m, "Snapdragon S4 Plus", "1280 x 768", "4.5 inch", "158g" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "ID", "Link", "MobileID" },
                values: new object[,]
                {
                    { 1, "https://fdn2.gsmarena.com/vv/pics/apple/apple-iphone-11-pro-max-4.jpg", 1 },
                    { 11, "https://fdn2.gsmarena.com/vv/bigpic/apple-iphone-11-pro-max-.jpg", 1 },
                    { 2, "https://fdn2.gsmarena.com/vv/pics/apple/apple-iphone-7-3.jpg", 2 },
                    { 3, "https://fdn2.gsmarena.com/vv/bigpic/samsung-galaxy-s20-ultra-.jpg", 3 }
                });

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "ID",
                keyValue: 1,
                column: "Link",
                value: "https://www.youtube.com/watch?v=OoY7zp8GkLI&ab_channel=MarquesBrownlee");

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "ID", "Link", "MobileID" },
                values: new object[,]
                {
                    { 2, "https://www.youtube.com/watch?v=nxf41fMX_Y4&ab_channel=MarquesBrownlee", 2 },
                    { 3, "https://www.youtube.com/watch?v=ZdC9soHxVC8&ab_channel=MarquesBrownlee", 3 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "ID", "Link", "MobileID" },
                values: new object[,]
                {
                    { 4, "https://fdn2.gsmarena.com/vv/bigpic/samsung-galaxy-s-4-i9500-black-mist.jpg", 4 },
                    { 5, "https://fdn2.gsmarena.com/vv/pics/huawei/huawei-honor-4c-1.jpg", 5 },
                    { 6, "https://fdn2.gsmarena.com/vv/pics/huawei/huawei-p30-1.jpg", 6 },
                    { 7, "https://fdn2.gsmarena.com/vv/bigpic/apple-iphone-se-2020.jpg", 7 },
                    { 8, "https://fdn2.gsmarena.com/vv/bigpic/samsung-galaxy-a80-.jpg", 8 },
                    { 9, "https://fdn2.gsmarena.com/vv/pics/xiaomi/xiaomi-redmi-note-9-4.jpg", 9 },
                    { 10, "https://fdn2.gsmarena.com/vv/pics/nokia/nokia-lumia-1020.jpg", 10 }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "ID", "Link", "MobileID" },
                values: new object[,]
                {
                    { 4, "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy", 4 },
                    { 5, "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy", 5 },
                    { 6, "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy", 6 },
                    { 7, "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy", 7 },
                    { 8, "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy", 8 },
                    { 9, "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy", 9 },
                    { 10, "https://www.youtube.com/watch?v=zrc2UAMnr94&ab_channel=UnboxTherapy", 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "ID",
                keyValue: 1,
                column: "Link",
                value: "http://google.com");
        }
    }
}
