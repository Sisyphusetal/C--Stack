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
            //Error handling
            return RedirectToAction("Index");
        }
    }

    [HttpGet("/dishes/{id}")]
    public IActionResult ShowDish(int id)
    {
        Dish OneDish = db.Dishes.FirstOrDefault(a => a.DishId == id);
        return View("OneDish", OneDish);
    }

    [HttpGet("dishes/{id}/edit")]
    public IActionResult EditDish(int id)
    {
        Dish? DishToEdit = db.Dishes.FirstOrDefault(i => i.DishId == id);
        return View("EditDish", DishToEdit);
    }

    [HttpPost("dishes/{id}/update")]
    public IActionResult UpdateDish(Dish editDish, int id)
    {
        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == id);

        if (dish == null)
        {
            return RedirectToAction("Index");
        }

        if (ModelState.IsValid)
        {
            dish.Name = editDish.Name;
            dish.Chef = editDish.Chef;
            dish.Tastiness = editDish.Tastiness;
            dish.Calories = editDish.Calories;
            dish.Description = editDish.Description;

            db.Dishes.Update(dish);
            db.SaveChanges();

            return RedirectToAction("ShowDish", new { id = id });
        }
        else
        {
            return View("EditDish", dish);
        }
    }

    [HttpPost("dishes/{id}/delete")]
    public IActionResult DeleteDish(int id)
    {
        Dish? DishToDelete = db.Dishes.SingleOrDefault(i => i.DishId == id);

        if(DishToDelete == null) 
        {
            return RedirectToAction("EditDish");
        }
        
        db.Dishes.Remove(DishToDelete);
        db.SaveChanges();

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
