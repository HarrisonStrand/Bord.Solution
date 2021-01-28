using BordClient.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BordClient.Controllers
{
    public class GenresController : Controller
    {
        public IActionResult Index()
        {
            var allGenres = Genre.GetGenres();
            return View(allGenres);
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            Genre.Post(genre);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var genre = Genre.GetDetails(id);
            return View(genre);
        }

        public IActionResult Edit(int id)
        {
            var genre = Genre.GetDetails(id);
            return View(genre);
        }

        [HttpPost]
        public IActionResult Details(int id, Genre genre)
        {
            genre.GenreId = id;
            Genre.Put(genre);
            return RedirectToAction("Details", id);
        }

        public IActionResult Delete(int id)
        {
            Genre.Delete(id);
            return RedirectToAction("Index");
        }
    }
}