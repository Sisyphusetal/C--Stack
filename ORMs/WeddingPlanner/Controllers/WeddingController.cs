using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using WeddingPlanner.Models;
using System.Runtime.ExceptionServices;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers;

[SessionCheck]
public class WeddingController : Controller
{
    private readonly ILogger<WeddingController> _logger;

    private MyContext db;

    public WeddingController(ILogger<WeddingController> logger, MyContext context)
    {
        _logger = logger;
        db = context;
    }


    [HttpGet("/weddings")]
    public IActionResult AllWeddings()
    {
        List<Wedding> AllWeddings = db.Weddings.Include(c => c.Creator).ToList();
        return View(AllWeddings);
    }

    [HttpGet("/weddings/new")]
    public IActionResult PlanWedding()
    {
        // List<Chef> AllChefs = db.Chefs.ToList();
        // ViewBag.AllChefs = AllChefs;
        return View();
    }

    [HttpPost("/weddings/create")]
    public IActionResult CreateWedding(Wedding newWedding)
    {
        if (!ModelState.IsValid)
        {
            // List<Chef> AllChefs = db.Chefs.ToList();
            // ViewBag.AllChefs = AllChefs;
            return View("ViewWedding");
        }

        db.Weddings.Add(newWedding);
        db.SaveChanges();
        return RedirectToAction("ViewWedding", new {id = newWedding.WeddingId});
    }

    [HttpGet("/weddings/{id}")]
    public IActionResult ViewWedding(int id)
    {
        Wedding OneWedding = db.Weddings.FirstOrDefault(w => w.WeddingId == id);
        return View(OneWedding);
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

    public class SessionCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Find the session, but remember it may be null so we need int?
            int? userId = context.HttpContext.Session.GetInt32("UUID");
            // Check to see if we got back null
            if (userId == null)
            {
                // Redirect to the Index page if there was nothing in session
                // "Home" here is referring to "HomeController", you can use any controller that is appropriate here
                context.Result = new RedirectToActionResult("Index", "User", null);
            }
        }
    }


}
