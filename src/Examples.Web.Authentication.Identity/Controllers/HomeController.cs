using System.Diagnostics;
using Examples.Web.Authentication.Identity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Web.Authentication.Identity.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogTrace("Index called.");
        return View();
    }

    public IActionResult Privacy()
    {
        _logger.LogTrace("Privacy called.");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
