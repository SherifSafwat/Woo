using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class _6251 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Param",
                table: "Param");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Param");

            migrationBuilder.AddColumn<int>(
                name: "ParamId",
                table: "Param",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ParamId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Param",
                table: "Param",
                column: "ParamId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ParamId",
                table: "AspNetUsers",
                column: "ParamId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AspNetUsers_Param_ParamId",
            //    table: "AspNetUsers",
            //    column: "ParamId",
            //    principalTable: "Param",
            //    principalColumn: "ParamId",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Param_ParamId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Param",
                table: "Param");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ParamId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ParamId",
                table: "Param");

            migrationBuilder.DropColumn(
                name: "ParamId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Param",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Param",
                table: "Param",
                column: "ID");
        }
    }
}
