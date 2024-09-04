using Microsoft.AspNetCore.Mvc;

namespace ViewBag.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        ViewBag.Username = "Kermit The Frog";
        ViewBag.Muppets = new List<string> { "Kermit", "Miss Piggy", "Fozzie Bear" };
        return View("Index");
    }
}