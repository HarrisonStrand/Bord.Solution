using System.Collections.Generic;

namespace BordAPI.Models
{
  public class Review
  {
    public int ReviewID { get; set; }
    public string Title { get; set; }
    public string Experience { get; set; } //review text
    public int LearningCurve { get; set; } //Numerical rating 1-10
    public string Suggestion { get; set; } //Tips/Suggestions that may help newer players better enjoy the game ex. how to turn into a drinking game, change rule to speed up play...  
    public int GameId { get; set; }
    public virtual Game Game { get; set; }
    public int UserId { get; set; }
  }
}