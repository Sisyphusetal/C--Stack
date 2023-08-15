using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext db;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        db = context;
    }

    public IActionResult Index()
    {
        List<Dish> AllDishes = db.Dishes.ToList();
        return View();
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
            //Error handling
            return RedirectToAction("Index");
        }
    }

    [HttpGet("/dishes/{id}")]
    public IActionResult ShowDish(int id)
    {
        Dish OneDish = db.Dishes.FirstOrDefault(a => a.DishId == id);
        return View(OneDish);
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
