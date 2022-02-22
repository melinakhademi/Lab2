using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieLab.Models;

namespace MovieLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var actors = Actor.GetAllActors();
            var movies = Movie.GetAllMovies();
            return View();
        }

        public IActionResult OldMovies()
        {
            var movies = Movie.GetAllMovies().Where(movie => movie.ReleaseYear < 2000).ToList();
            var moviesNewest = movies.OrderByDescending(movies => movies.ReleaseYear).ToList();
            return View(moviesNewest);
        }

        public IActionResult RobinWilliams()
        {
            var movies = Movie.GetAllMovies().Where(movie => movie.ActorList.Contains("robinwilliams")).ToList();
            var movieAlp = movies.OrderBy(movies => movies.Title).ToList();
            return View(movieAlp);
        }

        public IActionResult ThreeActors()
        {
            var movies = Movie.GetAllMovies().Where(x => x.ActorList.Count == 3).ToList();
            var moviesOldest = movies.OrderBy(movies => movies.ReleaseYear).ToList();
            return View(moviesOldest);
        }

        public IActionResult MovieDetails(int Id)
        {
            var movie = Movie.GetAllMovies().FirstOrDefault(movie => movie.Id == Id);
            return View(movie);
        }

        public IActionResult ActorDetails(string Id)
        {
            var actor = Actor.GetAllActors().FirstOrDefault(actor => actor.Id == Id);
            return View(actor);
        }

        public IActionResult GenreDrama()
        {
            var movies = Movie.GetAllMovies().Where(movie => movie.Genre.Contains("Drama")).ToList();
            var moviesDescending = movies.OrderByDescending(movies => movies.ReleaseYear).ToList();
            return View(moviesDescending);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
