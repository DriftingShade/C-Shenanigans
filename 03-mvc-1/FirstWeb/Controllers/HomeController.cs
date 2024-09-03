using Microsoft.AspNetCore.Mvc;

namespace FirstWeb.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public string Index()
    {
        return "Index Page edited!";
    }

    [HttpGet("about")]
    public string About()
    {
        return "About Page";
    }

    [HttpGet("services")]
    public string Services()
    {
        return "Services Page";
    }

    [HttpGet("services/{service}")]
    public string ServicePage(string service)
    {
        return $"Service: {service}";
    }

    [HttpGet("services/{service}/details/{serviceId}")]
    public string ServiceIdPage(string service, int serviceId)
    {
        return $"{service}: {serviceId}";
    }

    [HttpGet("portfolio/{portfolioId}")]

    public string PortfolioPage(int portfolioId)
    {
        return $"Viewing Project: {portfolioId}";
    }

    [HttpGet("repeat/{word}/{times}")]
    public string Repeat(string word, int times)
    {
        var output = "";
        for (var i = 0; i < times; i++)
        {
            output = output + word + "\n";
        }
        return output;
    }
}