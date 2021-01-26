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
  [Route("api/reviews")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private BordAPIContext _db;
    public ReviewsController(BordAPIContext db)
    {
      _db = db;
    }
    //GET api/reviews
    [HttpGet]
    public ActionResult<IEnumerable<Review>> Get(int? learningCurve, int? gameId)
    {
      var query = _db.Reviews
        .Include(review=>review.Game)
        .ThenInclude(game=>game.Genres)
        .ThenInclude(join=>join.Genre)
        .OrderBy(review=>review.ReviewId)
        .AsQueryable();
      if (learningCurve != null)
      {
        query = query.Where(entry => entry.LearningCurve == learningCurve);
      }
      if (gameId != null)
      {
        query = query.Where(entry => entry.GameId == gameId);
      }
      return query.ToList();
    }
    //POST api/reviews
    [HttpPost]
    public void Post([FromBody] Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
    }
    //GET api/reviews/{id}
    [HttpGet("{id}")]
    public ActionResult<Review> Get(int id)
    {
      return _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
    }
    // PUT api/reviews/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Review review)
    {
      review.ReviewId = id;
      _db.Entry(review).State = EntityState.Modified;
      _db.SaveChanges();
    }
    //DELETE api/reviews/{id}
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      Review reviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
      _db.Reviews.Remove(reviewToDelete);
      _db.SaveChanges();
    }
  }
}