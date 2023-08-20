using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace connect_four__server.Migrations
{
    public partial class addedmoves : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Moves",
                table: "Game",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Moves",
                table: "Game");
        }
    }
}
