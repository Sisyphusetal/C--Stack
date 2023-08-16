using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;
using System;

namespace ChefsAndDishes.Controllers;

public class ChefController : Controller
{
    private readonly ILogger<ChefController> _logger;

    private MyContext db;

    public ChefController(ILogger<ChefController> logger, MyContext context)
    {
        _logger = logger;
        db = context;
    }

    public IActionResult Index()
    {
        List<Chef> AllChefs = db.Chefs.ToList();
        return View(AllChefs);
    }

    [HttpGet("/chefs/new")]
    public IActionResult AddChef()
    {
        return View("AddChef");
    }

    [HttpPost("/chefs/create")]
    public IActionResult CreateChef(Chef newChef)
    {
        if (ModelState.IsValid)
        {
            db.Add(newDish);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        else
        {
            return View("AddDish");
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
