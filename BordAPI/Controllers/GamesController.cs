using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using BordAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace BordAPI.Controllers
{
  [Route("api/games")]
  [ApiController]
  public class GamesController : ControllerBase
  {
    private BordAPIContext _db;
    public GamesController(BordAPIContext db)
    {
      _db = db;
    }

    //GET api/games
    [HttpGet]
    public ActionResult<IEnumerable<Game>> Get(string gameName, int? minPlayers, int? maxPlayers, int? minAge, int? playTimeMin, string search, bool random)
    {
      var query = _db.Games
        .Include(game => game.Genres)
        .ThenInclude(join => join.Genre)
        .Include(game => game.Reviews)
        .AsQueryable();
      if (gameName != null)
      {
        query = query.Where(entry => entry.GameName.Contains(gameName));
      }
      if (minPlayers != null)
      {
        query = query.Where(entry => entry.MinPlayers >= minPlayers);
      }
      if (maxPlayers != null)
      {
        query = query.Where(entry => entry.MaxPlayers <= maxPlayers);
      }
      if (search != null)
      {
        query = query.Where(entry => entry.GameName.Contains(search));
      }
      if (random != false)
      {
        Random rnd = new Random();
        int toSkip = rnd.Next(0, _db.Games.Count());
        Game randomGame = _db.Games.OrderBy(r => Guid.NewGuid()).Skip(toSkip).Take(1).First();

        query = query.Where(entry => entry.GameId == randomGame.GameId);
      }
      return query.ToList();
    }
    //POST api/games
    [HttpPost]
    public void Post([FromBody] Game game, int id)
    {
      _db.Games.Add(game);
      if (id != 0)
      {
        _db.GameGenre.Add(new GameGenre() { GameId = game.GameId, GenreId = id });
      }
      _db.SaveChanges();
    }

    //GET api/games/{id}
    [HttpGet("{id}")]
    public ActionResult <IEnumerable<Game>> Get(int id)
    {
        return _db.Games.FirstOrDefault(entry => entry.GameId == id)
        .Include(game => game.Genres)
        .ThenInclude(join => join.Genre)
        .Include(game => game.Reviews)
        .AsQueryable();
    }

    //PUT api/games/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Game game)
    {
      game.GameId = id;
      _db.Entry(game).State = EntityState.Modified;
      _db.SaveChanges();
    }
    //DELETE api/games/{id}
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      Game gameToDelete = _db.Games.FirstOrDefault(entry => entry.GameId == id);
      _db.Games.Remove(gameToDelete);
      _db.SaveChanges();
    }

    // [HttpPost]
    // public void AddReview(Game game)
    // {
    //   _db.Games.Add(new Review() { GameId = game.GameId});
    //   _db.SaveChanges();
    //   //return RedirectToAction("Details", "Games", new {id = game.GameId});
    // }
  }
}
