using System.Threading.Tasks;
using RestSharp;

namespace MtSafeClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"reports", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"reports/{id}?api-version=2.0", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task Post(string newReport)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"reports", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newReport);
      var response = await client.ExecuteTaskAsync(request);    
    }
    public static async Task Put(int id, string newReport)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"reports/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newReport);
      var response = await client.ExecuteTaskAsync(request);    
    }

    public static async Task Delete (int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"reports/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response  = await client.ExecuteTaskAsync(request);
    }
  }
}