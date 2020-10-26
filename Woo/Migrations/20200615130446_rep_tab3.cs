using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class rep_tab3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ReportTail_ReportHeadId",
                table: "ReportTail",
                column: "ReportHeadId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReportTail_ReportHead_ReportHeadId",
                table: "ReportTail",
                column: "ReportHeadId",
                principalTable: "ReportHead",
                principalColumn: "ReportHeadId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReportTail_ReportHead_ReportHeadId",
                table: "ReportTail");

            migrationBuilder.DropIndex(
                name: "IX_ReportTail_ReportHeadId",
                table: "ReportTail");
        }
    }
}
