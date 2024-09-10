using Microsoft.AspNetCore.Mvc;
using Recap.Interfaces;
using Recap.Models;

namespace Recap.Controllers;

public class MovieController : Controller
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet("movies/dashboard")]
    public IActionResult MovieDashboard()
    {
        if (HttpContext.Session.GetString("username") == null)
        {
            return RedirectToAction("Index", "Home", new {message = "not-allowed"});
        }
        var username = HttpContext.Session.GetString("username");
        ViewBag.Username = username;
        return View("MovieDashboard");
    }

    [HttpGet("movies")]
    public IActionResult AllMovies()
    {
        if (HttpContext.Session.GetString("username") == null)
        {
            return RedirectToAction("Index", "Home", new {message = "not-allowed"});
        }
        var movies = _movieService.GetMovies();
        return View("AllMovies", movies);
    }

    [HttpGet("movies/new")]
    public IActionResult NewMovie()
    {
        if (HttpContext.Session.GetString("username") == null)
        {
            return RedirectToAction("Index", "Home", new {message = "not-allowed"});
        }
        return View("NewMovie");
    }

    [HttpPost("movies/create")]
    public IActionResult CreateMovie(Movie movie)
    {
        if(!ModelState.IsValid)
        {
            return View("NewMovie");
        }

        return RedirectToAction("AllMovies");
    }
}