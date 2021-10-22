using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinAuctionWebsite.Migrations
{
    public partial class migrate1 : Migration
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
                name: "Bidder_Bid_Regists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bidder_IDID = table.Column<int>(type: "int", nullable: true),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    Regist_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bidder_Bid_Regists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bidder_Bid_Regists_Bidders_Bidder_IDID",
                        column: x => x.Bidder_IDID,
                        principalTable: "Bidders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "Bid_Order_Logs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bidder_Bid_Regist_IDID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bid_Order_Logs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bid_Order_Logs_Bidder_Bid_Regists_Bidder_Bid_Regist_IDID",
                        column: x => x.Bidder_Bid_Regist_IDID,
                        principalTable: "Bidder_Bid_Regists",
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
                    Sub_CategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Sub_category_Sub_CategoryID",
                        column: x => x.Sub_CategoryID,
                        principalTable: "Sub_category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bid_Coin_Trans_Logs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bid_Coin_Pack_IDID = table.Column<int>(type: "int", nullable: true),
                    Bidder_IDID = table.Column<int>(type: "int", nullable: true),
                    Bid_Order_Log_IDID = table.Column<int>(type: "int", nullable: true),
                    Transaction_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Coin_Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bid_Coin_Trans_Logs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bid_Coin_Trans_Logs_Bid_Coin_Packs_Bid_Coin_Pack_IDID",
                        column: x => x.Bid_Coin_Pack_IDID,
                        principalTable: "Bid_Coin_Packs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bid_Coin_Trans_Logs_Bid_Order_Logs_Bid_Order_Log_IDID",
                        column: x => x.Bid_Order_Log_IDID,
                        principalTable: "Bid_Order_Logs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bid_Coin_Trans_Logs_Bidders_Bidder_IDID",
                        column: x => x.Bidder_IDID,
                        principalTable: "Bidders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product_Images",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_IDID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Images", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Images_Products_Product_IDID",
                        column: x => x.Product_IDID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bid_Coin_Trans_Logs_Bid_Coin_Pack_IDID",
                table: "Bid_Coin_Trans_Logs",
                column: "Bid_Coin_Pack_IDID");

            migrationBuilder.CreateIndex(
                name: "IX_Bid_Coin_Trans_Logs_Bid_Order_Log_IDID",
                table: "Bid_Coin_Trans_Logs",
                column: "Bid_Order_Log_IDID");

            migrationBuilder.CreateIndex(
                name: "IX_Bid_Coin_Trans_Logs_Bidder_IDID",
                table: "Bid_Coin_Trans_Logs",
                column: "Bidder_IDID");

            migrationBuilder.CreateIndex(
                name: "IX_Bid_Order_Logs_Bidder_Bid_Regist_IDID",
                table: "Bid_Order_Logs",
                column: "Bidder_Bid_Regist_IDID");

            migrationBuilder.CreateIndex(
                name: "IX_Bid_Orders_BidderID",
                table: "Bid_Orders",
                column: "BidderID");

            migrationBuilder.CreateIndex(
                name: "IX_Bidder_Bid_Regists_Bidder_IDID",
                table: "Bidder_Bid_Regists",
                column: "Bidder_IDID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Images_Product_IDID",
                table: "Product_Images",
                column: "Product_IDID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Sub_CategoryID",
                table: "Products",
                column: "Sub_CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Sub_category_CategoryID",
                table: "Sub_category",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bid_Coin_Trans_Logs");

            migrationBuilder.DropTable(
                name: "Bid_Orders");

            migrationBuilder.DropTable(
                name: "Product_Images");

            migrationBuilder.DropTable(
                name: "Bid_Coin_Packs");

            migrationBuilder.DropTable(
                name: "Bid_Order_Logs");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Bidder_Bid_Regists");

            migrationBuilder.DropTable(
                name: "Sub_category");

            migrationBuilder.DropTable(
                name: "Bidders");

            migrationBuilder.DropTable(
                name: "Product_Categories");
        }
    }
}
