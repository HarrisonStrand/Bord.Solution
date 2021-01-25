using System.Collections.Generic;

namespace BordAPI.Models
{
  public class Genre
  {
    public Genre()
    {
      this.Games = new HashSet<GameGenre>();
    }
    public int GenreId { get; set; }
    public string GenreName { get; set; }
    public virtual ICollection<GameGenre> Games { get; }
  }
}