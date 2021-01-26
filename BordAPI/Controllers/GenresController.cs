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
  [Route("api/genres")]
  [ApiController]
  public class GenresController : ControllerBase
  {
    private BordAPIContext _db;
    public GenresController(BordAPIContext db)
    {
      _db = db;
    }
    //GET api/genres
    [HttpGet]
    public ActionResult<IEnumerable<Genre>> Get(string genreName)
    { 
      var query=_db.Genres
      .Include(genre=>genre.Games)
      .ThenInclude(join=>join.Game)
      .ThenInclude(game=>game.Reviews)
      .AsQueryable();
      if (genreName != null)
      {
        query = query.Where(entry => entry.GenreName.Contains(genreName));
      }
      return query.ToList();
    }
    //POST api/genres
    [HttpPost]
    public void Post([FromBody]Genre genre)
    {
      _db.Genres.Add(genre);
      _db.SaveChanges();
    }
    //GET api/genres/{id}
    [HttpGet("{id}")]
    public ActionResult<Genre> Get(int id)
    {
      return _db.Genres.FirstOrDefault(entry => entry.GenreId == id);
    }
    // PUT api/genres/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Genre genre)
    {
      genre.GenreId = id;
      _db.Entry(genre).State = EntityState.Modified;
      _db.SaveChanges();
    }
    //DELETE api/genres/{id}
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      Genre genreToDelete = _db.Genres.FirstOrDefault(entry => entry.GenreId == id);
      _db.Genres.Remove(genreToDelete);
      _db.SaveChanges();
    }
  }
}