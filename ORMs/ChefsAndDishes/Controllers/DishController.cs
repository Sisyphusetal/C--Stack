using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;
using System;

namespace ChefsAndDishes.Controllers;

public class DishController : Controller
{
    private readonly ILogger<DishController> _logger;

    private MyContext db;

    public DishController(ILogger<DishController> logger, MyContext context)
    {
        _logger = logger;
        db = context;
    }


    [HttpGet("/dishes")]
    public IActionResult AllDishes()
    {
        List<Dish> AllDishes = db.Dishes.ToList();
        return View(AllDishes);
    }

    [HttpGet("/dishes/new")]
    public IActionResult NewDish()
    {
        return View("NewDish");
    }

    [HttpPost("/dishes/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if (ModelState.IsValid)
        {
            db.Add(newDish);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        else
        {
            return View("NewDish");
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
