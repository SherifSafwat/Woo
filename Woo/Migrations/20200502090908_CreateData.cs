using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class CreateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Item");

            migrationBuilder.AddColumn<string>(
                name: "DataComment",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "Item",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "GrantBy",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GrantComment",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GrantFromDate",
                table: "Item",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "GrantToDate",
                table: "Item",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Info1",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info2",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info3",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info4",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Info5",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemNum",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SysComment",
                table: "Item",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerNum = table.Column<int>(nullable: false),
                    EName = table.Column<string>(nullable: true),
                    AName = table.Column<string>(nullable: true),
                    DataComment = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    Address3 = table.Column<string>(nullable: true),
                    Address4 = table.Column<string>(nullable: true),
                    Address5 = table.Column<string>(nullable: true),
                    Contact1 = table.Column<string>(nullable: true),
                    Contact2 = table.Column<string>(nullable: true),
                    Contact3 = table.Column<string>(nullable: true),
                    Contact4 = table.Column<string>(nullable: true),
                    Contact5 = table.Column<string>(nullable: true),
                    Comment1 = table.Column<string>(nullable: true),
                    Comment2 = table.Column<string>(nullable: true),
                    Comment3 = table.Column<string>(nullable: true),
                    Comment4 = table.Column<string>(nullable: true),
                    Comment5 = table.Column<string>(nullable: true),
                    SourceID = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatedID = table.Column<int>(nullable: false),
                    UpdatingDate = table.Column<DateTime>(nullable: false),
                    UpdatedID = table.Column<int>(nullable: false),
                    SysComment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrinceNum = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    Prince = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Prices", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropColumn(
                name: "DataComment",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "GrantBy",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "GrantComment",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "GrantFromDate",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "GrantToDate",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Info1",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Info2",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Info3",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Info4",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Info5",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ItemNum",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "SysComment",
                table: "Item");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
