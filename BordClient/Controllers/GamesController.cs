using BordClient.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace BordClient.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Index()
        {
            var allGames = Game.GetGames();
            return View(allGames);
        }
        [HttpPost]
        public IActionResult Index(Game game)
        {
            Game.Post(game);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var game = Game.GetDetails(id);
            return View(game);
        }

        public IActionResult Edit(int id)
        {
            var game = Game.GetDetails(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Details(int id, Game game)
        {
            game.GameId = id;
            Game.Put(game);
            return RedirectToAction("Details", id);
        }

        public IActionResult Delete(int id)
        {
            Game.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult AddReview()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReview(Review review, int id)
        {
            review.GameId = id;
            Review.Post(review);
            return RedirectToAction("Index");
        }

    public ActionResult AddGenre(int id)
    {
        Genre thisGenre = _db.Genres.FirstOrDefault(genre => genre.GenreId == id);
        ViewBag.GenreId = new SelectList(_db.Genres, "GenreId", "GenreName");
        return View(thisGenre);
    }

    [HttpPost]
    public ActionResult AddGenre(Flavor flavor, int GenreId)
    {
        if (GenreId != 0)
        {
            var returnedJoin = _db.GenreFlavor
            .Any(join => join.FlavorId == flavor.FlavorId && join.GenreId == GenreId);
            if (!returnedJoin)
            {
            _db.GenreFlavor.Add(new GenreFlavor() { FlavorId = flavor.FlavorId, GenreId=GenreId});
            }
        }
        _db.SaveChanges();
        return RedirectToAction("Details", "Flavors", new { id = flavor.FlavorId });
    }
    
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
        
            Game.Post(game);
            return RedirectToAction("Index");
        }
    }
}