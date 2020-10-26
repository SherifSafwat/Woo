using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class _6191 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Seller",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Seller");

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "Warehouse",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "Seller",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "GenUserName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seller",
                table: "Seller",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_SellerId",
                table: "Warehouse",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SellerId",
                table: "AspNetUsers",
                column: "SellerId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AspNetUsers_Seller_SellerId",
            //    table: "AspNetUsers",
            //    column: "SellerId",
            //    principalTable: "Seller",
            //    principalColumn: "SellerId",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Warehouse_Seller_SellerId",
            //    table: "Warehouse",
            //    column: "SellerId",
            //    principalTable: "Seller",
            //    principalColumn: "SellerId",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Seller_SellerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_Seller_SellerId",
                table: "Warehouse");

            migrationBuilder.DropIndex(
                name: "IX_Warehouse_SellerId",
                table: "Warehouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seller",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SellerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "GenUserName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Warehouse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Seller",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seller",
                table: "Seller",
                column: "ID");
        }
    }
}
