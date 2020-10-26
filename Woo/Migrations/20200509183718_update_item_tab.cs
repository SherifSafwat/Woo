using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class update_item_tab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LineId",
                table: "InvoiceT");

            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "InvoiceT");

            migrationBuilder.AddColumn<int>(
                name: "TaxId",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemNum",
                table: "InvoiceT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LineNum",
                table: "InvoiceT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LineTax",
                table: "InvoiceT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PriceListId",
                table: "InvoiceT",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ItemNum",
                table: "InvoiceT");

            migrationBuilder.DropColumn(
                name: "LineNum",
                table: "InvoiceT");

            migrationBuilder.DropColumn(
                name: "LineTax",
                table: "InvoiceT");

            migrationBuilder.DropColumn(
                name: "PriceListId",
                table: "InvoiceT");

            migrationBuilder.AddColumn<int>(
                name: "LineId",
                table: "InvoiceT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PriceId",
                table: "InvoiceT",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
