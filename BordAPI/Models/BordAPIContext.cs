using Microsoft.EntityFrameworkCore;
using BordAPI.Entities;

namespace BordAPI.Models
{
  public class BordAPIContext : DbContext
  {
    public BordAPIContext(DbContextOptions<BordAPIContext> options)
        : base(options)
    {
    }
    public DbSet<Review> Reviews { get; set; } //virtual?
    public DbSet<Game> Games { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<GameGenre> GameGenre { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Genre>()
        .HasData(
          new Genre { GenreId = 1, GenreName = "Horror" },
          new Genre { GenreId = 2, GenreName = "Strategy" },
          new Genre { GenreId = 3, GenreName = "Cooperative" },
          new Genre { GenreId = 4, GenreName = "Mystery" },
          new Genre { GenreId = 5, GenreName = "Comedy" },
          new Genre { GenreId = 6, GenreName = "Puzzle" },
          new Genre { GenreId = 7, GenreName = "Party" },
          new Genre { GenreId = 8, GenreName = "Family" }
        );
      builder.Entity<GameGenre>()
        .HasData(
          new GameGenre { GameGenreId = 1, GameId = 1, GenreId = 6 },
          new GameGenre { GameGenreId = 2, GameId = 2, GenreId = 6 },
          new GameGenre { GameGenreId = 3, GameId = 3, GenreId = 3 },
          new GameGenre { GameGenreId = 4, GameId = 4, GenreId = 2 },
          new GameGenre { GameGenreId = 5, GameId = 5, GenreId = 1 },
          new GameGenre { GameGenreId = 6, GameId = 6, GenreId = 4 },
          new GameGenre { GameGenreId = 7, GameId = 7, GenreId = 1 },
          new GameGenre { GameGenreId = 8, GameId = 8, GenreId = 7 },
          new GameGenre { GameGenreId = 9, GameId = 9, GenreId = 8 },
          new GameGenre { GameGenreId = 10, GameId = 10, GenreId = 8 },
          new GameGenre { GameGenreId = 11, GameId = 11, GenreId = 2 },
          new GameGenre { GameGenreId = 12, GameId = 12, GenreId = 2 },
          new GameGenre { GameGenreId = 13, GameId = 1, GenreId = 5 },
          new GameGenre { GameGenreId = 14, GameId = 2, GenreId = 8 }

        );

      builder.Entity<Game>()
        .HasData(
          new Game { GameId = 1, GameName = "9 Tiles Panic", GamePrice = 35.99F, MinPlayers = 2, MaxPlayers = 6, Creators = "Oink Games", MinAge = 12, PlayTimeMin = 30 },
          new Game { GameId = 2, GameName = "Scrabble", GamePrice = 20.00F, MinPlayers = 2, MaxPlayers = 4, Creators = "Hasbro", MinAge = 5, PlayTimeMin = 60 },
          new Game { GameId = 3, GameName = "Codenames", GamePrice = 14.99F, MinPlayers = 2, MaxPlayers = 8, Creators = "Vlaada Chvatil", MinAge = 14, PlayTimeMin = 15 },
          new Game { GameId = 4, GameName = "Odin's Ravens", GamePrice = 21.99F, MinPlayers = 2, MaxPlayers = 2, Creators = "Thorsten Gimmler", MinAge = 10, PlayTimeMin = 30 },
          new Game { GameId = 5, GameName = "Arkham Horror", GamePrice = 44.99F, MinPlayers = 1, MaxPlayers = 2, Creators = "Nate French, Matthew Newman", MinAge = 14, PlayTimeMin = 60 },
          new Game { GameId = 6, GameName = "Mysterium", GamePrice = 54.99F, MinPlayers = 2, MaxPlayers = 7, Creators = "Oleksandr Nevskiy, Oleg Sidorenko", MinAge = 10, PlayTimeMin = 42 },
          new Game { GameId = 7, GameName = "Nemesis", GamePrice = 144.00F, MinPlayers = 1, MaxPlayers = 5, Creators = "Adam Kwapiński", MinAge = 12, PlayTimeMin = 90 },
          new Game { GameId = 8, GameName = "Jenga", GamePrice = 14.99F, MinPlayers = 1, MaxPlayers = 8, Creators = "Leslie Scott", MinAge = 6, PlayTimeMin = 20 },
          new Game { GameId = 9, GameName = "Zombie Kidz Evolution", GamePrice = 22.99F, MinPlayers = 2, MaxPlayers = 4, Creators = "Annick Lobet", MinAge = 7, PlayTimeMin = 15 },
          new Game { GameId = 10, GameName = "Monopoly", GamePrice = 14.99F, MinPlayers = 2, MaxPlayers = 6, Creators = "Hasbro", MinAge = 5, PlayTimeMin = 120 },
          new Game { GameId = 11, GameName = "Chess", GamePrice = 14.99F, MinPlayers = 1, MaxPlayers = 2, Creators = "Unknown", MinAge = 4, PlayTimeMin = 30 },
          new Game { GameId = 12, GameName = "Risk", GamePrice = 24.99F, MinPlayers = 2, MaxPlayers = 6, Creators = "Hasbro", MinAge = 8, PlayTimeMin = 90 }
        );

      builder.Entity<Review>()
        .HasData(
          new Review { ReviewId = 1, Title = "9 Times the Fun", Experience = "WooHoo", LearningCurve = 3, Suggestion = "More people the better.", GameId = 1 },
          new Review { ReviewId = 2, Title = "Oldie but goodie", Experience = "Shouldn't have watched queens gambit", LearningCurve = 8, Suggestion = "Study the greats", GameId = 11 },
          new Review { ReviewId = 3, Title = "Try to fly", Experience = "This game was great", LearningCurve = 4, Suggestion = "Plan ahead but don't get caught without a card.", GameId = 4 }
        );
    }


  }
}