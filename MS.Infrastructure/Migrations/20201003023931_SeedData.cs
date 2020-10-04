using Microsoft.EntityFrameworkCore.Migrations;

namespace MS.Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mobiles",
                columns: new[] { "ID", "Dimensions", "Manufacturer", "Memory", "Name", "OS", "Price", "Processor", "Resolution", "ScreenSize", "Weight" },
                values: new object[] { 1, "144mm X 71.4mm X 8.1mm", "Apple", "4GB", "Iphone 11 pro", "IOS", 3500m, "hexa-core Apple A13", "2436 x 1125", "5.8 inch", "188g" });

            migrationBuilder.InsertData(
                table: "Mobiles",
                columns: new[] { "ID", "Dimensions", "Manufacturer", "Memory", "Name", "OS", "Price", "Processor", "Resolution", "ScreenSize", "Weight" },
                values: new object[] { 2, "144mm X 71.4mm X 8.1mm", "Apple", "3GB", "Iphone 7", "IOS", 1800m, "hexa-core Apple A9", "2436 x 1125", "4.7 inch", "159g" });

            migrationBuilder.InsertData(
                table: "Mobiles",
                columns: new[] { "ID", "Dimensions", "Manufacturer", "Memory", "Name", "OS", "Price", "Processor", "Resolution", "ScreenSize", "Weight" },
                values: new object[] { 3, "144mm X 71.4mm X 8.1mm", "Samsung", "6GB", "Galaxy s20", "Android", 3500m, "Snapdragon 855", "2436 x 1125", "6.1 inch", "188g" });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "ID", "Link", "MobileID" },
                values: new object[] { 1, "http://google.com", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
