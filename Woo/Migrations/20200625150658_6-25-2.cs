using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class _6252 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Param");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Param",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
