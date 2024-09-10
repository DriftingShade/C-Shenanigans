using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Recap.Models;

namespace Recap.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {

        return View("Index");
    }

    [HttpPost("usernames/remember")]
    public IActionResult RememberUsername(Username username)
    {
        if (!ModelState.IsValid)
        {
            _logger.LogInformation("Username form is invalid.");
            return View("Index");
        }

        _logger.LogInformation("Username form is valid.");
        HttpContext.Session.SetString("username", username.Content);
        return RedirectToAction("MovieDashboard", "Movie");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
