using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class user_tab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SellerID",
                table: "User",
                newName: "SellerId");

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "User",
                newName: "SellerID");
        }
    }
}
