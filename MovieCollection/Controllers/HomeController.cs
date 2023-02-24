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
            if (ModelState.IsValid)
            {
                _Context.Add(ar);
                _Context.SaveChanges();
            
                return View("Confirmation", ar);
            }

            else
            {
                ViewBag.Categories = _Context.Categories.ToList();

                return View(ar);
            }
        }

        [HttpGet]
        public IActionResult Collection()
        {
            ViewBag.Categories = _Context.Categories.ToList();

            var movies = _Context.Responses.Include(x => x.Category).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _Context.Categories.ToList();

            var movie = _Context.Responses.Single(x => x.MovieId == movieid);

            return View("AddAMovie", movie);
        }

        [HttpPost]
        public IActionResult Edit (MovieEntry x)
        {
            ViewBag.Categories = _Context.Categories.ToList();
            _Context.Update(x);
            _Context.SaveChanges();

            return RedirectToAction("Collection");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = _Context.Responses.Single(x => x.MovieId == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieEntry ar)
        {
            _Context.Responses.Remove(ar);
            _Context.SaveChanges();
            return RedirectToAction("Collection");
        }
    }
}
