using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfumeOnlineShop.Migrations
{
    public partial class Correct3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 5,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\MVersace1.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 5,
                column: "ImageThumbnailUrl",
                value: "\\Images\\MenuThumbnail\\MVersace1 .jpg");
        }
    }
}
