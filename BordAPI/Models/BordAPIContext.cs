using Microsoft.EntityFrameworkCore;

namespace BordAPI.Models
{
  public class BordAPIContext : DbContext
  {
    public BordAPIContext(DbContextOptions<BordAPIContext> options)
        : base(options)
        {
        }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Game> Games { get; set; }
  }
}