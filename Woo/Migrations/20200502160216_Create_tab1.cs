using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class Create_tab1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resp",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RespNum = table.Column<int>(nullable: false),
                    EName = table.Column<string>(nullable: true),
                    AName = table.Column<string>(nullable: true),
                    DataComment = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatedID = table.Column<int>(nullable: false),
                    UpdatingDate = table.Column<DateTime>(nullable: false),
                    UpdatedID = table.Column<int>(nullable: false),
                    SysComment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resp", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerNum = table.Column<int>(nullable: false),
                    EName = table.Column<string>(nullable: true),
                    AName = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Seller", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNum = table.Column<int>(nullable: false),
                    EName = table.Column<string>(nullable: true),
                    AName = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    SellerID = table.Column<int>(nullable: false),
                    DeviceId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserResp",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRespNum = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    RespId = table.Column<int>(nullable: false),
                    DataComment = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_UserResp", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resp");

            migrationBuilder.DropTable(
                name: "Seller");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserResp");
        }
    }
}
