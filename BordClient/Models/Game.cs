using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System;


namespace BordClient.Models
{
  public class Game
  {
    public int GameId {get; set; }
    public string GameName {get; set; }
    public float GamePrice {get; set; }
    public int MinPlayers {get; set; }
    public int MaxPlayers {get; set; }
    public string Creators {get; set; }
    public int MinAge {get; set; }
    public int GenreId {get; set; }
    public int PlayTimeMin {get; set; }

    public static List<Game> GetGames()
    {
      var apiCallTask = GamesApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Game> gameList = JsonConvert.DeserializeObject<List<Game>>(jsonResponse.ToString());

      return gameList;
    }

    public static Game GetDetails(int id)
    {
      var apiCallTask = GamesApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Game game = JsonConvert.DeserializeObject<Game>(jsonResponse.ToString());

      return game;
    }
    public static void Post(Game game)
    {
      string jsonGame = JsonConvert.SerializeObject(game);
      var apiCallTask = GamesApiHelper.Post(jsonGame);
    }
    public static void Put(Game game)
    {
      string jsonGame = JsonConvert.SerializeObject(game);
      var apiCallTask = GamesApiHelper.Put(game.GameId, jsonGame);
    }

    public static void Delete (int id)
    {
      var apiCallTask = GamesApiHelper.Delete(id);
    }
  }
}