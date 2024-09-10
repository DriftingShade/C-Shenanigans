using Microsoft.AspNetCore.Mvc;
using Recap.Interfaces;

namespace Recap.Controllers;

public class MovieController : Controller
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public ViewResult MovieDashboard()
    {
        var username = HttpContext.Session.GetString("username");
        ViewBag.Username = username;
        return View("MovieDashboard");
    }
}