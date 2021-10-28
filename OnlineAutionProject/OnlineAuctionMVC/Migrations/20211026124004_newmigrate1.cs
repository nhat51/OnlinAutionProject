using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineAuctionMVC.Migrations
{
    public partial class newmigrate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Bidder_Bid_Regists");

            migrationBuilder.AddColumn<int>(
                name: "Bid_Order_IDID",
                table: "Bidder_Bid_Regists",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bidder_Bid_Regists_Bid_Order_IDID",
                table: "Bidder_Bid_Regists",
                column: "Bid_Order_IDID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bidder_Bid_Regists_Bid_Orders_Bid_Order_IDID",
                table: "Bidder_Bid_Regists",
                column: "Bid_Order_IDID",
                principalTable: "Bid_Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bidder_Bid_Regists_Bid_Orders_Bid_Order_IDID",
                table: "Bidder_Bid_Regists");

            migrationBuilder.DropIndex(
                name: "IX_Bidder_Bid_Regists_Bid_Order_IDID",
                table: "Bidder_Bid_Regists");

            migrationBuilder.DropColumn(
                name: "Bid_Order_IDID",
                table: "Bidder_Bid_Regists");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Bidder_Bid_Regists",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
