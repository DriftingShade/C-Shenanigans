using Microsoft.AspNetCore.Mvc;

namespace ViewBag.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }
}