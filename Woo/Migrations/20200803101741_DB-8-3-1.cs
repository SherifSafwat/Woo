using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class DB831 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address3",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address4",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address5",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact1",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact2",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact3",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact4",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact5",
                table: "Client",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address1",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Address3",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Address4",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Address5",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Contact1",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Contact2",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Contact3",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Contact4",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Contact5",
                table: "Client");
        }
    }
}
