using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class report10_tab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportH");

            migrationBuilder.DropTable(
                name: "ReportT");

            migrationBuilder.CreateTable(
                name: "ReportHead",
                columns: table => new
                {
                    ReportHeadId = table.Column<int>(nullable: false)
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
                    Param10 = table.Column<string>(nullable: true),
                    Param11 = table.Column<string>(nullable: true),
                    Param12 = table.Column<string>(nullable: true),
                    Param13 = table.Column<string>(nullable: true),
                    Param14 = table.Column<string>(nullable: true),
                    Param15 = table.Column<string>(nullable: true),
                    Param16 = table.Column<string>(nullable: true),
                    Param17 = table.Column<string>(nullable: true),
                    Param18 = table.Column<string>(nullable: true),
                    Param19 = table.Column<string>(nullable: true),
                    HeaderParam0 = table.Column<string>(nullable: true),
                    HeaderParam1 = table.Column<string>(nullable: true),
                    HeaderParam2 = table.Column<string>(nullable: true),
                    HeaderParam3 = table.Column<string>(nullable: true),
                    HeaderParam4 = table.Column<string>(nullable: true),
                    HeaderParam5 = table.Column<string>(nullable: true),
                    HeaderParam6 = table.Column<string>(nullable: true),
                    HeaderParam7 = table.Column<string>(nullable: true),
                    HeaderParam8 = table.Column<string>(nullable: true),
                    HeaderParam9 = table.Column<string>(nullable: true),
                    HeaderParam10 = table.Column<string>(nullable: true),
                    HeaderParam11 = table.Column<string>(nullable: true),
                    HeaderParam12 = table.Column<string>(nullable: true),
                    HeaderParam13 = table.Column<string>(nullable: true),
                    HeaderParam14 = table.Column<string>(nullable: true),
                    HeaderParam15 = table.Column<string>(nullable: true),
                    HeaderParam16 = table.Column<string>(nullable: true),
                    HeaderParam17 = table.Column<string>(nullable: true),
                    HeaderParam18 = table.Column<string>(nullable: true),
                    HeaderParam19 = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_ReportHead", x => x.ReportHeadId);
                });

            migrationBuilder.CreateTable(
                name: "ReportTail",
                columns: table => new
                {
                    ReportTailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportHeadId = table.Column<int>(nullable: false),
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
                    Header10 = table.Column<string>(nullable: true),
                    Header11 = table.Column<string>(nullable: true),
                    Header12 = table.Column<string>(nullable: true),
                    Header13 = table.Column<string>(nullable: true),
                    Header14 = table.Column<string>(nullable: true),
                    Header15 = table.Column<string>(nullable: true),
                    Header16 = table.Column<string>(nullable: true),
                    Header17 = table.Column<string>(nullable: true),
                    Header18 = table.Column<string>(nullable: true),
                    Header19 = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_ReportTail", x => x.ReportTailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportHead");

            migrationBuilder.DropTable(
                name: "ReportTail");

            migrationBuilder.CreateTable(
                name: "ReportH",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GrantBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrantComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrantFromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GrantToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Header0 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam0 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParam9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param0 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Param9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportADesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportAName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportEDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportEName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportSQL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SysComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportH", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReportT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    GrantBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrantComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrantFromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GrantToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Header0 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    SysComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportT", x => x.ID);
                });
        }
    }
}
