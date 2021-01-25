using System.Collections.Generic;

namespace BordAPI.Models
{
  public class Review
  {
    public int ReviewID { get; set; }
    public string Title { get; set; }
    public string Experience { get; set; }
    public int LearningCurve { get; set; }
    public string Suggestion { get; set; }
    public List<Game> SimilarGames { get; set; } //?
    public int GameId { get; set; }

    public virtual Game Game { get; set; }
    public int UserId { get; set; }
  }
}