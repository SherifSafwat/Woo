using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class update_price_tab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceNum = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    ItemPrice = table.Column<int>(nullable: false),
                    Comment1 = table.Column<string>(nullable: true),
                    Comment2 = table.Column<string>(nullable: true),
                    Comment3 = table.Column<string>(nullable: true),
                    Comment4 = table.Column<string>(nullable: true),
                    Comment5 = table.Column<string>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false),
                    GrantBy = table.Column<int>(nullable: false),
                    GrantFromDate = table.Column<DateTime>(nullable: false),
                    GrantToDate = table.Column<DateTime>(nullable: false),
                    GrantComment = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatedID = table.Column<int>(nullable: false),
                    UpdatingDate = table.Column<DateTime>(nullable: false),
                    UpdatedID = table.Column<int>(nullable: false),
                    SysComment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Price_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Price_ItemId",
                table: "Price",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Price");

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    GrantBy = table.Column<int>(type: "int", nullable: false),
                    GrantComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrantFromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GrantToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Prince = table.Column<int>(type: "int", nullable: false),
                    PrinceNum = table.Column<int>(type: "int", nullable: false),
                    SysComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedID = table.Column<int>(type: "int", nullable: false),
                    UpdatingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.ID);
                });
        }
    }
}
