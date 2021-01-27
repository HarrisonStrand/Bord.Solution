using System.Threading.Tasks;
using RestSharp;

namespace BordClient.Models
{
  class GamesApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"games", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"games/{id}?api-version=2.0", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task Post(string newGame)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"games", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newGame);
      var response = await client.ExecuteTaskAsync(request);    
    }
    public static async Task Put(int id, string newGame)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"games/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newGame);
      var response = await client.ExecuteTaskAsync(request);    
    }

    public static async Task Delete (int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"games/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response  = await client.ExecuteTaskAsync(request);
    }

    public static async Task AddReview(string newReview)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"games", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newReview);
      var response = await client.ExecuteTaskAsync(request);    
    }
  }
}