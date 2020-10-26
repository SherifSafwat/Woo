using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class param_tab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Param",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Param1 = table.Column<int>(nullable: false),
                    Param2 = table.Column<int>(nullable: false),
                    Param3 = table.Column<int>(nullable: false),
                    Param4 = table.Column<int>(nullable: false),
                    Param5 = table.Column<int>(nullable: false),
                    Param6 = table.Column<int>(nullable: false),
                    Param7 = table.Column<int>(nullable: false),
                    Param8 = table.Column<int>(nullable: false),
                    Param9 = table.Column<int>(nullable: false),
                    Param10 = table.Column<int>(nullable: false),
                    Param11 = table.Column<int>(nullable: false),
                    Param12 = table.Column<int>(nullable: false),
                    Param13 = table.Column<int>(nullable: false),
                    Param14 = table.Column<int>(nullable: false),
                    Param15 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Param", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Param");
        }
    }
}
