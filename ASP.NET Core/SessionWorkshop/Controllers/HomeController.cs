using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionWorkshop.Models;

namespace SessionWorkshop.Controllers;

public class HomeController : Controller
{

    private const string SessionNameKey = "Name";
    private const string SessionValueKey = "Value";


    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string name)
    {
        HttpContext.Session.SetString(SessionNameKey, name);
        HttpContext.Session.SetInt32(SessionValueKey, 22); // Starting value
        return RedirectToAction("Dashboard");
    }

    [HttpGet]
    public IActionResult Dashboard()
{
    var name = HttpContext.Session.GetString(SessionNameKey);
    if (string.IsNullOrEmpty(name))
    {
        return RedirectToAction("Index");
    }

    ViewBag.Name = name; // Set the name in the ViewBag
    ViewBag.Value = HttpContext.Session.GetInt32(SessionValueKey);
    return View();
}


    [HttpPost]
    public IActionResult Action(string operation)
    {
        var value = HttpContext.Session.GetInt32(SessionValueKey) ?? 0;

        switch (operation)
        {
            case "add":
                value += 1;
                break;
            case "minus":
                value -= 1;
                break;
            case "multiply":
                value *= 2;
                break;
            case "random":
                value += new Random().Next(1, 11);
                break;
        }

        HttpContext.Session.SetInt32(SessionValueKey, value);
        return RedirectToAction("Dashboard");
    }


    [HttpPost]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
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
