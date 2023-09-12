using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PriceChecker.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Markets_Products_ProductId",
                table: "Markets");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Markets");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Markets");

            migrationBuilder.AddColumn<string>(
                name: "BussinessName",
                table: "Sellers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MarketId",
                table: "Sellers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Markets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Markets_Products_ProductId",
                table: "Markets",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Markets_Products_ProductId",
                table: "Markets");

            migrationBuilder.DropColumn(
                name: "BussinessName",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "MarketId",
                table: "Sellers");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Markets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Markets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Markets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Markets_Products_ProductId",
                table: "Markets",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
