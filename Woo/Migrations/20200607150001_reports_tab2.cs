using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class reports_tab2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_ReportT", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportT");
        }
    }
}
