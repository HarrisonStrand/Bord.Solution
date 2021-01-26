using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BordAPI.Migrations
{
    public partial class Reset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GameName = table.Column<string>(nullable: true),
                    GamePrice = table.Column<float>(nullable: false),
                    MinPlayers = table.Column<int>(nullable: true),
                    MaxPlayers = table.Column<int>(nullable: true),
                    Creators = table.Column<string>(nullable: true),
                    MinAge = table.Column<int>(nullable: true),
                    PlayTimeMin = table.Column<int>(nullable: true),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GenreName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Experience = table.Column<string>(nullable: true),
                    LearningCurve = table.Column<int>(nullable: true),
                    Suggestion = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameGenre",
                columns: table => new
                {
                    GameGenreId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GameId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameGenre", x => x.GameGenreId);
                    table.ForeignKey(
                        name: "FK_GameGenre_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameGenre_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "GameGenre",
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
                name: "IX_GameGenre_GameId",
                table: "GameGenre",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameGenre_GenreId",
                table: "GameGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GameId",
                table: "Reviews",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameGenre");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
