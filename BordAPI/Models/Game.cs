using System.Collections.Generic;

namespace BordAPI.Models
{
  public class Game
  {
    public Game()
    {
      this.Genres = new HashSet<GameGenre>();
      this.Reviews = new HashSet<Review>();
    }
    public int GameId { get; set; }
    public string GameName { get; set; }
    public float GamePrice { get; set; }
    public int? MinPlayers { get; set; }
    public int? MaxPlayers { get; set; }
    public string Creators { get; set; }
    public int? MinAge { get; set; }
    public int? PlayTimeMin { get; set; }
    public int GenreId { get; set; }
    //public Genre Genre { get; set; }
    public virtual ICollection<GameGenre> Genres{get;}
    public virtual ICollection<Review> Reviews {get;set;}

  }
}