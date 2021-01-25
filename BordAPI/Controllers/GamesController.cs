using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using BordAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

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
    public ActionResult<IEnumerable<Game>> Get()
    {
      return _db.Games.ToList();
    }
    
    //POST api/games
    [HttpPost]
    public void Post([FromBody] Game game)
    {
      _db.Games.Add(game);
      _db.SaveChanges();
    }
    //GET api/games/{id}
    [HttpGet("{id}")]
    public ActionResult<Game> GetAction(int id)
    {
      return _db.Games.FirstOrDefault(entry => entry.GameId == id);
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


  }
}