using Microsoft.EntityFrameworkCore.Migrations;

namespace ParfumeOnlineShop.Migrations
{
    public partial class Correct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 10,
                column: "Price",
                value: 150.95m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parfume",
                keyColumn: "ParfumeId",
                keyValue: 10,
                column: "Price",
                value: 1450.95m);
        }
    }
}
