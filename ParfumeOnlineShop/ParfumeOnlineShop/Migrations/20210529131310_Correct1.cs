using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfumeOnlineShop.Migrations
{
    public partial class Correct1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "IsParfumeOfTheMonth", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\MCalvinKlein .jpg", true, 142.99m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "LongDescription", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\MDolceGabbana .jpg", "A fragrance that is both classic and modern, vibrant and engaging. A spicy, oriental perfume, developed on the harmony of tobacco with refined boisé notes.", 168.49m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "InStock", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\MValentino .jpg", false, 18.95m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\MVersace .jpg", 155.75m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "LongDescription", "Name", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\MVersace1 .jpg", "A harmonious blend of woods, oriental balms and fresh citrus notes. A sophisticated masculine perfume, unforgettable.”", "Versace man new", 199.99m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "InStock", "LongDescription", "Price", "ShortDescription" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZChanel .jpg", true, "A harmonious blend of woods, oriental balms and fresh citrus notes. A sophisticated masculine perfume, unforgettable.", 172.99m, "Grilled Pizza With Steak, Pear, and Arugula" });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 7,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsParfumeOfTheMonth", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 1, "\\Images\\MenuThumbnail\\ZChanel 1.jpg", "\\Images\\Menu\\ZChanel 1.jpg", false, false, "The essence of a bold, free woman. An airy, oriental-fresh fragrance, housed in a refillable spray.", "Chanel women new", 186.45m, "An iconic bottle, perfect for travel." });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "IsParfumeOfTheMonth", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZScandal .jpg", true, 125.99m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "IsParfumeOfTheMonth", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZSexySecret .jpg", true, 143.95m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZSkin.jpg", "\\Images\\Menu\\ZSkin.jpg", true, "The fragrance itself is a hymn of joyful living and transports you to a world where time is suspended and women have the courage to make themselves a priority..", 112.99m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "InStock", "IsParfumeOfTheMonth", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZValentino .jpg", false, false, 135.95m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 12,
                columns: new[] { "ImageThumbnailUrl", "InStock", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZVersace .jpg", true, 185.45m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 13,
                columns: new[] { "IsParfumeOfTheMonth", "Price" },
                values: new object[] { false, 48.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "IsParfumeOfTheMonth", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\MCalvinKlein.jpg", false, 187.95m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "LongDescription", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\MDolceGabbana.jpg", " A fragrance that is both classic and modern, vibrant and engaging. A spicy, oriental perfume, developed on the harmony of tobacco with refined boisé notes.", 189.95m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "InStock", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\MValentino.jpg", true, 155.95m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\MVersace.jpg", 139.95m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "LongDescription", "Name", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\MVersace1.jpg", "A harmonious blend of woods, oriental balms and fresh citrus notes. A sophisticated masculine perfume, unforgettable.", "Versace man1", 170.95m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "InStock", "LongDescription", "Price", "ShortDescription" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZChanel.jpg", false, "The essence of a bold, free woman. An airy, oriental-fresh fragrance, housed in a refillable spray.", 155.95m, " An iconic bottle, perfect for travel. " });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 7,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsParfumeOfTheMonth", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, "\\Images\\MenuThumbnail\\ZChanel1.jpg", "\\Images\\Menu\\ZChanel1.jpg", true, true, "A feminine oriental fragrance with a voluptuous yet surprisingly fresh composition. A daring fragrance housed in an iconic bottle hand-sealed with a baudruche film. ", "Chanel women 1", 127.95m, "The essence of a bold, free woman." });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "IsParfumeOfTheMonth", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZScandal.jpg", false, 150.95m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "IsParfumeOfTheMonth", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZSexySecret.jpg", false, 180.95m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZSkinn.jpg", "\\Images\\Menu\\ZSkinn.jpg", false, "The fragrance itself is a hymn of joyful living and transports you to a world where time is suspended and women have the courage to make themselves a priority.", 150.95m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "InStock", "IsParfumeOfTheMonth", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZValentino.jpg", true, true, 130.95m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 12,
                columns: new[] { "ImageThumbnailUrl", "InStock", "Price" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZVersace.jpg", false, 164.95m });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 13,
                columns: new[] { "IsParfumeOfTheMonth", "Price" },
                values: new object[] { true, 100.95m });
        }
    }
}
