using Microsoft.EntityFrameworkCore.Migrations;

namespace BordAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "ReviewID",
                table: "Reviews",
                newName: "ReviewId");

            migrationBuilder.AlterColumn<int>(
                name: "LearningCurve",
                table: "Reviews",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PlayTimeMin",
                table: "Games",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MinPlayers",
                table: "Games",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MinAge",
                table: "Games",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MaxPlayers",
                table: "Games",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Creators", "GameName", "GamePrice", "GenreId", "MaxPlayers", "MinAge", "MinPlayers", "PlayTimeMin" },
                values: new object[,]
                {
                    { 1, "Oink Games", "9 Tiles Panic", 35.99f, 0, 6, 12, 2, 30 },
                    { 12, "Hasbro", "Risk", 24.99f, 0, 6, 8, 2, 90 },
                    { 11, "Unknown", "Chess", 14.99f, 0, 2, 4, 1, 30 },
                    { 9, "Annick Lobet", "Zombie Kidz Evolution", 22.99f, 0, 4, 7, 2, 15 },
                    { 8, "Leslie Scott", "Jenga", 14.99f, 0, 8, 6, 1, 20 },
                    { 7, "Adam Kwapiński", "Nemesis", 144f, 0, 5, 12, 1, 90 },
                    { 10, "Hasbro", "Monopoly", 14.99f, 0, 6, 5, 2, 120 },
                    { 5, "Nate French, Matthew Newman", "Arkham Horror", 44.99f, 0, 2, 14, 1, 60 },
                    { 4, "Thorsten Gimmler", "Odin's Ravens", 21.99f, 0, 2, 10, 2, 30 },
                    { 3, "Vlaada Chvatil", "Codenames", 14.99f, 0, 8, 14, 2, 15 },
                    { 2, "Hasbro", "Scrabble", 20f, 0, 4, 5, 2, 60 },
                    { 6, "Oleksandr Nevskiy, Oleg Sidorenko", "Mysterium", 54.99f, 0, 7, 10, 2, 42 }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[,]
                {
                    { 7, "Party" },
                    { 1, "Horror" },
                    { 2, "Strategy" },
                    { 3, "Cooperative" },
                    { 4, "Mystery" },
                    { 5, "Comedy" },
                    { 6, "Puzzle" },
                    { 8, "Family" }
                });

            migrationBuilder.InsertData(
                table: "GameGenres",
                columns: new[] { "GameGenreId", "GameId", "GenreId" },
                values: new object[,]
                {
                    { 3, 3, 3 },
                    { 9, 9, 8 },
                    { 8, 8, 7 },
                    { 2, 2, 6 },
                    { 1, 1, 6 },
                    { 13, 1, 5 },
                    { 6, 6, 4 },
                    { 10, 10, 8 },
                    { 14, 2, 8 },
                    { 11, 11, 2 },
                    { 4, 4, 2 },
                    { 7, 7, 1 },
                    { 5, 5, 1 },
                    { 12, 12, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Experience", "GameId", "LearningCurve", "Suggestion", "Title" },
                values: new object[,]
                {
                    { 2, "Shouldn't have watched queens gambit", 11, 8, "Study the greats", "Oldie but goodie" },
                    { 3, "This game was great", 4, 4, "Plan ahead but don't get caught without a card.", "Try to fly" },
                    { 1, "WooHoo", 1, 3, "More people the better.", "9 Times the Fun" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreId",
                table: "Games",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Genres_GenreId",
                table: "Games",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Genres_GenreId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_GenreId",
                table: "Games");

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "GameGenreId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "Reviews",
                newName: "ReviewID");

            migrationBuilder.AlterColumn<int>(
                name: "LearningCurve",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Reviews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PlayTimeMin",
                table: "Games",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MinPlayers",
                table: "Games",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MinAge",
                table: "Games",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaxPlayers",
                table: "Games",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
