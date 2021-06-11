using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfumeOnlineShop.Migrations
{
    public partial class Correct2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\MCalvinKlein.jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\MDolceGabbana.jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\MValentino.jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 4,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\MVersace.jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 6,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\ZChanel.jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZChanel1.jpg", "\\Images\\Menu\\ZChanel1.jpg" });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 8,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\ZScandal.jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 9,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\ZSexySecret.jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZSkinn.jpg", "\\Images\\Menu\\ZSkinn.jpg" });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 11,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\ZValentino.jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 12,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\ZVersace.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\MCalvinKlein .jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\MDolceGabbana .jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\MValentino .jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 4,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\MVersace .jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 6,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\ZChanel .jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZChanel 1.jpg", "\\Images\\Menu\\ZChanel 1.jpg" });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 8,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\ZScandal .jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 9,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\ZSexySecret .jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\MenuThumbnail\\ZSkin.jpg", "\\Images\\Menu\\ZSkin.jpg" });

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 11,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\ZValentino .jpg");

            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 12,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\ZVersace .jpg");
        }
    }
}
