using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormWithValidation.Models;

namespace FormWithValidation.Controllers;

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

    [HttpPost("results")]
    public ViewResult Results(Knight knight)
    {
        if (!ModelState.IsValid)
        {
            _logger.LogInformation("The Form is invalid.");
            return View("Index");
        }
        else
        {
            _logger.LogInformation("The Form is valid.");
            return View("Results", knight);
        }
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
