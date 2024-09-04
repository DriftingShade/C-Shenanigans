using Microsoft.AspNetCore.Mvc;

namespace Redirecting.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public RedirectToActionResult Index()
    {
        return RedirectToAction("Home", new { word = "does this work?" });
    }
    [HttpGet("home/{word}")]
    public ViewResult Home(string word)
    {
        ViewBag.Word = word;
        return View("Home");
    }
}