using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieCollection.Models;
using System.Diagnostics;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _Context { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext contextName)
        {
            _logger = logger;
            _Context = contextName;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View("My Podcasts");
        }

        [HttpGet]
        public IActionResult AddAMovie()
        {
            return View("AddAMovie");
        }

        [HttpPost]
        public IActionResult AddAMovie(MovieEntry ar)
        {
            return View("Confirmation", ar);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
