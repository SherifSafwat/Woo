using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class createinvoiceh3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvoiceH",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNum = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    DeviceId = table.Column<int>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    InvoiceTime = table.Column<DateTime>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    TotalTax = table.Column<int>(nullable: false),
                    TotalDisc = table.Column<int>(nullable: false),
                    DataComment = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    CreatedID = table.Column<int>(nullable: true),
                    UpdatingDate = table.Column<DateTime>(nullable: true),
                    UpdatedID = table.Column<int>(nullable: true),
                    SysComment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceH", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceH");
        }
    }
}
