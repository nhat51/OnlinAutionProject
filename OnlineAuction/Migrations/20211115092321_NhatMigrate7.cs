using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineAuction.Migrations
{
    public partial class NhatMigrate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Auctions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Auctions");
        }
    }
}
