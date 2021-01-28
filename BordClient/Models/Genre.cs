using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System;


namespace BordClient.Models
{
	public class Genre
	{
		public int GenreId {get; set; }
		public string GenreName {get; set; }
		public int GameId { get; set; }

		public static List<Genre> GetGenres()
		{
			var apiCallTask = GenresApiHelper.GetAll();
			var result = apiCallTask.Result;

			JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
			List<Genre> genreList = JsonConvert.DeserializeObject<List<Genre>>(jsonResponse.ToString());

			return genreList;
		}

		public static Genre GetDetails(int id)
		{
			var apiCallTask = GenresApiHelper.Get(id);
			var result = apiCallTask.Result;

			JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
			Genre genre = JsonConvert.DeserializeObject<Genre>(jsonResponse.ToString());

			return genre;
		}
		public static void Post(Genre genre)
		{
		string jsonGenre = JsonConvert.SerializeObject(genre);
		var apiCallTask = GenresApiHelper.Post(jsonGenre);
		}
		public static void Put(Genre genre)
		{
		string jsonGenre = JsonConvert.SerializeObject(genre);
		var apiCallTask = GenresApiHelper.Put(genre.GenreId, jsonGenre);
		}

		public static void Delete (int id)
		{
		var apiCallTask = ReviewsApiHelper.Delete(id);
		}
	}
}