using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieCollection.Models;
using System.Linq;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _Context { get; set; }

        public HomeController(MovieContext contextName)
        {
            _Context = contextName;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddAMovie()
        {
            ViewBag.Categories = _Context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddAMovie(MovieEntry ar)
        {
            return View("Confirmation", ar);
        }

        public IActionResult Collection()
        {
            var movies = _Context.Responses.Include(x => x.Category);
            return View(movies);
        }
    }
}
