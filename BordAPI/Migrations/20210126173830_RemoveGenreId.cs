using Microsoft.EntityFrameworkCore.Migrations;

namespace BordAPI.Migrations
{
    public partial class RemoveGenreId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Games");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Games",
                nullable: false,
                defaultValue: 0);
        }
    }
}
