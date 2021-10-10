using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesTemplate.Migrations
{
    public partial class Referee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Referee",
                table: "Game",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Referee",
                table: "Game");
        }
    }
}
