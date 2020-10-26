using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Woo.Migrations
{
    public partial class _6211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SetterId",
                table: "Price");

            migrationBuilder.RenameColumn(
                name: "UpdatedID",
                table: "Receive",
                newName: "UpdatedId");

            migrationBuilder.RenameColumn(
                name: "CreatedID",
                table: "Receive",
                newName: "CreatedId");

            migrationBuilder.RenameColumn(
                name: "UpdatedID",
                table: "Price",
                newName: "UpdatedId");

            migrationBuilder.RenameColumn(
                name: "CreatedID",
                table: "Price",
                newName: "CreatedId");

            migrationBuilder.RenameColumn(
                name: "UpdatedID",
                table: "InvoiceH",
                newName: "UpdatedId");

            migrationBuilder.RenameColumn(
                name: "CreatedID",
                table: "InvoiceH",
                newName: "CreatedId");

            migrationBuilder.AddColumn<string>(
                name: "tt1",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BranchId",
                table: "Receive",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "Receive",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SourceId",
                table: "Receive",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BranchId",
                table: "Price",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "Price",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SourceId",
                table: "Price",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatingDate",
                table: "InvoiceT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedID",
                table: "InvoiceT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "InvoiceT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedID",
                table: "InvoiceT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BranchId",
                table: "InvoiceT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "InvoiceT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SourceId",
                table: "InvoiceT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatingDate",
                table: "InvoiceH",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedId",
                table: "InvoiceH",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "InvoiceH",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedId",
                table: "InvoiceH",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BranchId",
                table: "InvoiceH",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "InvoiceH",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SourceId",
                table: "InvoiceH",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Receive_SellerId",
                table: "Receive",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_SellerId",
                table: "Price",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceT_SellerId",
                table: "InvoiceT",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceH_SellerId",
                table: "InvoiceH",
                column: "SellerId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_InvoiceH_Seller_SellerId",
            //    table: "InvoiceH",
            //    column: "SellerId",
            //    principalTable: "Seller",
            //    principalColumn: "SellerId",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_InvoiceT_Seller_SellerId",
            //    table: "InvoiceT",
            //    column: "SellerId",
            //    principalTable: "Seller",
            //    principalColumn: "SellerId",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Price_Seller_SellerId",
            //    table: "Price",
            //    column: "SellerId",
            //    principalTable: "Seller",
            //    principalColumn: "SellerId",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Receive_Seller_SellerId",
            //    table: "Receive",
            //    column: "SellerId",
            //    principalTable: "Seller",
            //    principalColumn: "SellerId",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceH_Seller_SellerId",
                table: "InvoiceH");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceT_Seller_SellerId",
                table: "InvoiceT");

            migrationBuilder.DropForeignKey(
                name: "FK_Price_Seller_SellerId",
                table: "Price");

            migrationBuilder.DropForeignKey(
                name: "FK_Receive_Seller_SellerId",
                table: "Receive");

            migrationBuilder.DropIndex(
                name: "IX_Receive_SellerId",
                table: "Receive");

            migrationBuilder.DropIndex(
                name: "IX_Price_SellerId",
                table: "Price");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceT_SellerId",
                table: "InvoiceT");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceH_SellerId",
                table: "InvoiceH");

            migrationBuilder.DropColumn(
                name: "tt1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Receive");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Receive");

            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "Receive");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Price");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Price");

            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "Price");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "InvoiceT");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "InvoiceT");

            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "InvoiceT");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "InvoiceH");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "InvoiceH");

            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "InvoiceH");

            migrationBuilder.RenameColumn(
                name: "UpdatedId",
                table: "Receive",
                newName: "UpdatedID");

            migrationBuilder.RenameColumn(
                name: "CreatedId",
                table: "Receive",
                newName: "CreatedID");

            migrationBuilder.RenameColumn(
                name: "UpdatedId",
                table: "Price",
                newName: "UpdatedID");

            migrationBuilder.RenameColumn(
                name: "CreatedId",
                table: "Price",
                newName: "CreatedID");

            migrationBuilder.RenameColumn(
                name: "UpdatedId",
                table: "InvoiceH",
                newName: "UpdatedID");

            migrationBuilder.RenameColumn(
                name: "CreatedId",
                table: "InvoiceH",
                newName: "CreatedID");

            migrationBuilder.AddColumn<string>(
                name: "SetterId",
                table: "Price",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatingDate",
                table: "InvoiceT",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedID",
                table: "InvoiceT",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "InvoiceT",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedID",
                table: "InvoiceT",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatingDate",
                table: "InvoiceH",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedID",
                table: "InvoiceH",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "InvoiceH",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CreatedID",
                table: "InvoiceH",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
