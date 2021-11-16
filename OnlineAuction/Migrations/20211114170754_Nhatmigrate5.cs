using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineAuction.Migrations
{
    public partial class Nhatmigrate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_Products_ProductID",
                table: "Auctions");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Auctions",
                newName: "SubCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Auctions_ProductID",
                table: "Auctions",
                newName: "IX_Auctions_SubCategoryID");

            migrationBuilder.AddColumn<int>(
                name: "AuctionID",
                table: "ProdcutImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductName",
                table: "Auctions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProdcutImages_AuctionID",
                table: "ProdcutImages",
                column: "AuctionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_SubCategories_SubCategoryID",
                table: "Auctions",
                column: "SubCategoryID",
                principalTable: "SubCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdcutImages_Auctions_AuctionID",
                table: "ProdcutImages",
                column: "AuctionID",
                principalTable: "Auctions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_SubCategories_SubCategoryID",
                table: "Auctions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdcutImages_Auctions_AuctionID",
                table: "ProdcutImages");

            migrationBuilder.DropIndex(
                name: "IX_ProdcutImages_AuctionID",
                table: "ProdcutImages");

            migrationBuilder.DropColumn(
                name: "AuctionID",
                table: "ProdcutImages");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Auctions");

            migrationBuilder.RenameColumn(
                name: "SubCategoryID",
                table: "Auctions",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Auctions_SubCategoryID",
                table: "Auctions",
                newName: "IX_Auctions_ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_Products_ProductID",
                table: "Auctions",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
