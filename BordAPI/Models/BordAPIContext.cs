using Microsoft.EntityFrameworkCore;

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
    public DbSet<Genre> Genres { get; set; }//added
    public DbSet<GameGenre> GameGenres { get; set; }//added

    //lazy?
   

  }
}