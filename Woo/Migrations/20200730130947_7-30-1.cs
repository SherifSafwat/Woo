using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class _7301 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientNum = table.Column<int>(nullable: false),
                    EName = table.Column<string>(nullable: true),
                    AName = table.Column<string>(nullable: true),
                    DataComment = table.Column<string>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    Longitude = table.Column<int>(nullable: false),
                    Latitude = table.Column<int>(nullable: false),
                    DeviceId = table.Column<string>(nullable: true),
                    Info1 = table.Column<string>(nullable: true),
                    Info2 = table.Column<string>(nullable: true),
                    Info3 = table.Column<string>(nullable: true),
                    Info4 = table.Column<string>(nullable: true),
                    Info5 = table.Column<string>(nullable: true),
                    Comment1 = table.Column<string>(nullable: true),
                    Comment2 = table.Column<string>(nullable: true),
                    Comment3 = table.Column<string>(nullable: true),
                    Comment4 = table.Column<string>(nullable: true),
                    Comment5 = table.Column<string>(nullable: true),
                    SourceId = table.Column<int>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    GrantBy = table.Column<string>(nullable: true),
                    GrantFromDate = table.Column<DateTime>(nullable: false),
                    GrantToDate = table.Column<DateTime>(nullable: false),
                    GrantComment = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CreatedID = table.Column<string>(nullable: true),
                    UpdatingDate = table.Column<DateTime>(nullable: false),
                    UpdatedID = table.Column<string>(nullable: true),
                    SysComment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
