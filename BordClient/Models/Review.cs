using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System;


namespace BordClient.Models
{
  public class Review
  {
    public int ReviewId {get; set; }
    public string Title {get; set; }
    public string Experience {get; set; }
    public string LearningCurve {get; set; }
    public string Suggestions {get; set; }
    public string SimilarGames {get; set; }
    public int GameId { get; set; }
    public int UserId { get; set; }

    public static List<Review> GetReviews()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());

      return reviewList;
    }

    public static Review GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Review review = JsonConvert.DeserializeObject<Review>(jsonResponse.ToString());

      return review;
    }
    public static void Post(Review review)
    {
      string jsonReview = JsonConvert.SerializeObject(review);
      var apiCallTask = ApiHelper.Post(jsonReview);
    }
    public static void Put(Review review)
    {
      string jsonReview = JsonConvert.SerializeObject(review);
      var apiCallTask = ApiHelper.Put(review.ReviewId, jsonReview);
    }

    public static void Delete (int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}