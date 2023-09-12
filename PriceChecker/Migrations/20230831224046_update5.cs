using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PriceChecker.Migrations
{
    public partial class update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Markets_Products_ProductId",
                table: "Markets");

            migrationBuilder.DropIndex(
                name: "IX_Markets_ProductId",
                table: "Markets");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Markets");

            migrationBuilder.CreateTable(
                name: "MarketProduct",
                columns: table => new
                {
                    MarketsMarketId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketProduct", x => new { x.MarketsMarketId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_MarketProduct_Markets_MarketsMarketId",
                        column: x => x.MarketsMarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarketProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MarketProduct_ProductId",
                table: "MarketProduct",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketProduct");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Markets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Markets_ProductId",
                table: "Markets",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Markets_Products_ProductId",
                table: "Markets",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");
        }
    }
}
