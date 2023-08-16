using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

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
        List<Dish> AllDishes = db.Dishes.Include(c => c.Creator).ToList();
        return View(AllDishes);
    }

    [HttpGet("/dishes/new")]
    public IActionResult AddDish()
    {
        List<Chef> AllChefs = db.Chefs.ToList();
        ViewBag.AllChefs = AllChefs;
        return View();
    }

    [HttpPost("/dishes/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if (!ModelState.IsValid)
        {
            List<Chef> AllChefs = db.Chefs.ToList();
            ViewBag.AllChefs = AllChefs;
            return View("AddDish");
        }
        
        db.Dishes.Add(newDish);
        db.SaveChanges();
        return RedirectToAction("AllDishes");
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
