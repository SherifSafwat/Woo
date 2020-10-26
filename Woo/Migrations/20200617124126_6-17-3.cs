using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class _6173 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WareHouseId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_WareHouseId",
                table: "AspNetUsers",
                column: "WareHouseId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AspNetUsers_Warehouse_WareHouseId",
            //    table: "AspNetUsers",
            //    column: "WareHouseId",
            //    principalTable: "Warehouse",
            //    principalColumn: "WareHouseId",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_AspNetUsers_Warehouse_WareHouseId",
            //    table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_WareHouseId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WareHouseId",
                table: "AspNetUsers");
        }
    }
}
