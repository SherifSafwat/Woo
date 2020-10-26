using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class _7111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AreaId",
                table: "Warehouse",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Latitude",
                table: "Warehouse",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Longitude",
                table: "Warehouse",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceH_CustomerId",
                table: "InvoiceH",
                column: "CustomerId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_InvoiceH_Customer_CustomerId",
            //    table: "InvoiceH",
            //    column: "CustomerId",
            //    principalTable: "Customer",
            //    principalColumn: "CustomerId",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceH_Customer_CustomerId",
                table: "InvoiceH");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceH_CustomerId",
                table: "InvoiceH");

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Warehouse");
        }
    }
}
