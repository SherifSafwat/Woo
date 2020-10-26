using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class _6181 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SourceID",
                table: "Warehouse",
                newName: "SourceId");

            migrationBuilder.AddColumn<string>(
                name: "BranchId",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment1",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment2",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment3",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment4",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment5",
                table: "Warehouse",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Warehouse",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedID",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "GrantBy",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedID",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "BranchId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SourceId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "Comment1",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "Comment2",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "Comment3",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "Comment4",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "Comment5",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "SourceId",
                table: "Warehouse",
                newName: "SourceID");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedID",
                table: "Seller",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GrantBy",
                table: "Seller",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedID",
                table: "Seller",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
