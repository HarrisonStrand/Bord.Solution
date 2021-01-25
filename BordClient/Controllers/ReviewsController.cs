using BordClient.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BordClient.Controllers
{
  public class ReviewsController : Controller
  { 
    public IActionResult Index()
  {
    List<Review> allReviews = Review.GetReviews();
    return View(allReviews);
  }
  }
}