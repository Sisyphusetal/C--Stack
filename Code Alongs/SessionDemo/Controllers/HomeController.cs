using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionDemo.Models;

namespace SessionDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //HttpContext.Session.SetString("UserName", "Winter");


        return View();
    }

    [HttpPost("Login")]
    public IActionResult Login(string UserName)
    {
        HttpContext.Session.SetString("UserName", UserName);

        return RedirectToAction("Index");
    }

    [HttpGet("Logout")]
    public IActionResult Logout()
    {
        //HttpContext.Session.Remove("UserName");
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    [HttpGet("Player")]
    public IActionResult Player()
    {
        if (HttpContext.Session.GetString("UserName") == null)
        {
            return RedirectToAction("Index");
        }


        return View();
    }

    [HttpPost("UpdatePlayer")]
    public IActionResult UpdatePlayer(string CharacterName, int CharacterLevel)
    {
        HttpContext.Session.SetString("CharacterName", CharacterName);
        HttpContext.Session.SetInt32("CharacterLevel", CharacterLevel);

        int? IntVariable = HttpContext.Session.GetInt32("CharacterLevel");

        return RedirectToAction("Player");
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
