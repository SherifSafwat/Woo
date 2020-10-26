using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class Extend_IdentityUser3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment1",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment2",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment3",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment4",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment5",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact1",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact2",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact3",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact4",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact5",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedID",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DataComment",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeviceId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "GrantBy",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GrantComment",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GrantFromDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "GrantToDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SysComment",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedID",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatingDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "p_password",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "p_username",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Comment1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Comment2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Comment3",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Comment4",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Comment5",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Contact1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Contact2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Contact3",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Contact4",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Contact5",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DataComment",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GrantBy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GrantComment",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GrantFromDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GrantToDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SysComment",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatingDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "p_password",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "p_username",
                table: "AspNetUsers");
        }
    }
}
