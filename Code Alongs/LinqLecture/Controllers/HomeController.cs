using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LinqLecture.Models;

namespace LinqLecture.Controllers;

public class HomeController : Controller
{
    public static Game[] AllGames = new Game()
    {
        
    }



    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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
