using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class CreateTabs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvoiceT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(nullable: false),
                    LineId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    PriceId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    LineDisc = table.Column<int>(nullable: false),
                    TotalLine = table.Column<int>(nullable: false),
                    DataComment = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatedID = table.Column<int>(nullable: false),
                    UpdatingDate = table.Column<DateTime>(nullable: false),
                    UpdatedID = table.Column<int>(nullable: false),
                    SysComment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceT", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceT");
        }
    }
}
