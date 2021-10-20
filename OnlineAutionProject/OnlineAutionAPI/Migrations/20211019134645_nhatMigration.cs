using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineAutionAPI.Migrations
{
    public partial class nhatMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Product_Categories_CategoryID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Products",
                newName: "Sub_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                newName: "IX_Products_Sub_CategoryID");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Prodcut_Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sub_category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sub_Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_category", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sub_category_Product_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Product_Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prodcut_Images_ProductID",
                table: "Prodcut_Images",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Bidder_Bid_Regists_Bidder_ID",
                table: "Bidder_Bid_Regists",
                column: "Bidder_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Sub_category_CategoryID",
                table: "Sub_category",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bidder_Bid_Regists_Bidders_Bidder_ID",
                table: "Bidder_Bid_Regists",
                column: "Bidder_ID",
                principalTable: "Bidders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prodcut_Images_Products_ProductID",
                table: "Prodcut_Images",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sub_category_Sub_CategoryID",
                table: "Products",
                column: "Sub_CategoryID",
                principalTable: "Sub_category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bidder_Bid_Regists_Bidders_Bidder_ID",
                table: "Bidder_Bid_Regists");

            migrationBuilder.DropForeignKey(
                name: "FK_Prodcut_Images_Products_ProductID",
                table: "Prodcut_Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sub_category_Sub_CategoryID",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Sub_category");

            migrationBuilder.DropIndex(
                name: "IX_Prodcut_Images_ProductID",
                table: "Prodcut_Images");

            migrationBuilder.DropIndex(
                name: "IX_Bidder_Bid_Regists_Bidder_ID",
                table: "Bidder_Bid_Regists");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Prodcut_Images");

            migrationBuilder.RenameColumn(
                name: "Sub_CategoryID",
                table: "Products",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Sub_CategoryID",
                table: "Products",
                newName: "IX_Products_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Product_Categories_CategoryID",
                table: "Products",
                column: "CategoryID",
                principalTable: "Product_Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
