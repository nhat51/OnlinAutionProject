using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineAutionAPI.Migrations
{
    public partial class OnlineAution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bid_Coin_Packs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pack_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bid_Coins_Value = table.Column<int>(type: "int", nullable: false),
                    Bonus_Coin = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bid_Coin_Packs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bid_Coin_Trans_Logs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bid_Coin_Pack_ID = table.Column<int>(type: "int", nullable: false),
                    Bidder_ID = table.Column<int>(type: "int", nullable: false),
                    Bid_Order_Log_ID = table.Column<int>(type: "int", nullable: false),
                    Transaction_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Coin_Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bid_Coin_Trans_Logs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bid_Order_Logs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bidder_Bid_Regist_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bid_Order_Logs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bidder_Bid_Regists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bidder_ID = table.Column<int>(type: "int", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    Regist_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bidder_Bid_Regists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bidders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identity_Card_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_of_birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Current_bid_coins = table.Column<int>(type: "int", nullable: false),
                    Locked_bid_coins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bidders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prodcut_Images",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodcut_Images", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product_Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cat_Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bid_Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Bid_Start_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bid_End_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bid_Chair_Cost = table.Column<int>(type: "int", nullable: false),
                    Base_Price = table.Column<int>(type: "int", nullable: false),
                    Increment_Price_Per_Bid = table.Column<int>(type: "int", nullable: false),
                    Cool_Down_Time_Per_Bid = table.Column<int>(type: "int", nullable: false),
                    BidderID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bid_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bid_Orders_Bidders_BidderID",
                        column: x => x.BidderID,
                        principalTable: "Bidders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actual_cost_in_curency = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Product_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Product_Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bid_Orders_BidderID",
                table: "Bid_Orders",
                column: "BidderID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bid_Coin_Packs");

            migrationBuilder.DropTable(
                name: "Bid_Coin_Trans_Logs");

            migrationBuilder.DropTable(
                name: "Bid_Order_Logs");

            migrationBuilder.DropTable(
                name: "Bid_Orders");

            migrationBuilder.DropTable(
                name: "Bidder_Bid_Regists");

            migrationBuilder.DropTable(
                name: "Prodcut_Images");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Bidders");

            migrationBuilder.DropTable(
                name: "Product_Categories");
        }
    }
}
