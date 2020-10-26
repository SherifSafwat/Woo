using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class update_item_tabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GlobalBarCode",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocalBarCode",
                table: "Item",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GlobalBarCode",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "LocalBarCode",
                table: "Item");
        }
    }
}
