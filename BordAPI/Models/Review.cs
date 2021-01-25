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
    //private List<Game> _similarGames;
    public List<Game> SimilarGames {get; set; }///?
    // {
    //   get { return } // function to pull games of like genre
    //   set { _similarGames = value;}
    // }
    public int GameId { get; set; }
    public virtual Game Game { get; set; }
    public int UserId { get; set; }
  }
}