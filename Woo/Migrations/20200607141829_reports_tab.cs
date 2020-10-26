using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class reports_tab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    ReportName = table.Column<string>(nullable: true),
                    ReportSQL = table.Column<string>(nullable: true),
                    ReportDesc = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    Param1 = table.Column<string>(nullable: true),
                    Param2 = table.Column<string>(nullable: true),
                    Param3 = table.Column<string>(nullable: true),
                    Param4 = table.Column<string>(nullable: true),
                    Param5 = table.Column<string>(nullable: true),
                    Param6 = table.Column<string>(nullable: true),
                    Param7 = table.Column<string>(nullable: true),
                    Param8 = table.Column<string>(nullable: true),
                    Param9 = table.Column<string>(nullable: true),
                    Param10 = table.Column<string>(nullable: true),
                    Info1 = table.Column<string>(nullable: true),
                    Info2 = table.Column<string>(nullable: true),
                    Info3 = table.Column<string>(nullable: true),
                    Info4 = table.Column<string>(nullable: true),
                    Info5 = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Report", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReportH",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportEName = table.Column<string>(nullable: true),
                    ReportAName = table.Column<string>(nullable: true),
                    ReportSQL = table.Column<string>(nullable: true),
                    ReportEDesc = table.Column<string>(nullable: true),
                    ReportADesc = table.Column<string>(nullable: true),
                    Header0 = table.Column<string>(nullable: true),
                    Header1 = table.Column<string>(nullable: true),
                    Header2 = table.Column<string>(nullable: true),
                    Header3 = table.Column<string>(nullable: true),
                    Header4 = table.Column<string>(nullable: true),
                    Header5 = table.Column<string>(nullable: true),
                    Header6 = table.Column<string>(nullable: true),
                    Header7 = table.Column<string>(nullable: true),
                    Header8 = table.Column<string>(nullable: true),
                    Header9 = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    Param0 = table.Column<string>(nullable: true),
                    Param1 = table.Column<string>(nullable: true),
                    Param2 = table.Column<string>(nullable: true),
                    Param3 = table.Column<string>(nullable: true),
                    Param4 = table.Column<string>(nullable: true),
                    Param5 = table.Column<string>(nullable: true),
                    Param6 = table.Column<string>(nullable: true),
                    Param7 = table.Column<string>(nullable: true),
                    Param8 = table.Column<string>(nullable: true),
                    Param9 = table.Column<string>(nullable: true),
                    Info1 = table.Column<string>(nullable: true),
                    Info2 = table.Column<string>(nullable: true),
                    Info3 = table.Column<string>(nullable: true),
                    Info4 = table.Column<string>(nullable: true),
                    Info5 = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_ReportH", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "ReportH");
        }
    }
}
