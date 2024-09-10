using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClassicRockQuiz.Models;

namespace ClassicRockQuiz.Controllers;

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
        if (HttpContext.Session.GetInt32("Score") == null)
        {
            HttpContext.Session.SetInt32("Score", 0);
        }
        return View("Index");
    }

    [HttpGet("question-1")]

    public ViewResult Question1()
    {
        return View("Question1");
    }

    [HttpPost("process/question-1")]
    public IActionResult ProcessQuestion1(string choice)
    {
        if (choice == "Led Zeppelin")
        {
            int Score = HttpContext.Session.GetInt32("Score") ?? 0;
            Score++;
            Console.WriteLine(Score);
            HttpContext.Session.SetInt32("Score", Score);
        }

        return RedirectToAction("Question2");
    }

    [HttpGet("question-2")]

    public ViewResult Question2()
    {
        return View("Question2");
    }

    [HttpPost("process/question-2")]
    public IActionResult ProcessQuestion2(string choice)
    {
        if (choice == "1967")
        {
            int Score = HttpContext.Session.GetInt32("Score") ?? 0;
            Score++;
            Console.WriteLine(Score);
            HttpContext.Session.SetInt32("Score", Score);
        }

        return RedirectToAction("Question3");
    }

    [HttpGet("question-3")]

    public ViewResult Question3()
    {
        return View("Question3");
    }

    [HttpPost("process/question-3")]
    public IActionResult ProcessQuestion3(string choice)
    {
        if (choice == "The Eagles")
        {
            int Score = HttpContext.Session.GetInt32("Score") ?? 0;
            Score++;
            Console.WriteLine(Score);
            HttpContext.Session.SetInt32("Score", Score);
        }

        return RedirectToAction("Results");
    }

    [HttpGet("results")]
    public ViewResult Results()
    {
        ViewBag.Score = HttpContext.Session.GetInt32("Score") ?? 0;
        return View("Results");
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
