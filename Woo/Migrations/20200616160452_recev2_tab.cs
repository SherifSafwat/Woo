using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class recev2_tab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Receive",
                table: "Receive");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Receive");

            migrationBuilder.DropColumn(
                name: "ReceiptId",
                table: "Receive");

            migrationBuilder.AddColumn<int>(
                name: "ReceiveId",
                table: "Receive",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "Receive",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "GrantBy",
                table: "Receive",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GrantComment",
                table: "Receive",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GrantFromDate",
                table: "Receive",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "GrantToDate",
                table: "Receive",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserObjId",
                table: "Receive",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receive",
                table: "Receive",
                column: "ReceiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Receive_ItemId",
                table: "Receive",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Receive_UserObjId",
                table: "Receive",
                column: "UserObjId");

            migrationBuilder.CreateIndex(
                name: "IX_Receive_WarehouseId",
                table: "Receive",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receive_Item_ItemId",
                table: "Receive",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receive_AspNetUsers_UserObjId",
                table: "Receive",
                column: "UserObjId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receive_Warehouse_WarehouseId",
                table: "Receive",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receive_Item_ItemId",
                table: "Receive");

            migrationBuilder.DropForeignKey(
                name: "FK_Receive_AspNetUsers_UserObjId",
                table: "Receive");

            migrationBuilder.DropForeignKey(
                name: "FK_Receive_Warehouse_WarehouseId",
                table: "Receive");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Receive",
                table: "Receive");

            migrationBuilder.DropIndex(
                name: "IX_Receive_ItemId",
                table: "Receive");

            migrationBuilder.DropIndex(
                name: "IX_Receive_UserObjId",
                table: "Receive");

            migrationBuilder.DropIndex(
                name: "IX_Receive_WarehouseId",
                table: "Receive");

            migrationBuilder.DropColumn(
                name: "ReceiveId",
                table: "Receive");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "Receive");

            migrationBuilder.DropColumn(
                name: "GrantBy",
                table: "Receive");

            migrationBuilder.DropColumn(
                name: "GrantComment",
                table: "Receive");

            migrationBuilder.DropColumn(
                name: "GrantFromDate",
                table: "Receive");

            migrationBuilder.DropColumn(
                name: "GrantToDate",
                table: "Receive");

            migrationBuilder.DropColumn(
                name: "UserObjId",
                table: "Receive");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Receive",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ReceiptId",
                table: "Receive",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receive",
                table: "Receive",
                column: "ID");
        }
    }
}
