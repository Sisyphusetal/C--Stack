// This brings all the MVC features we need to this file
//using is equivalent to import from React
using Microsoft.AspNetCore.Mvc;

// Be sure to use your own project's namespace here!
//namespace should be the name of the assignment or project
namespace FirstWeb.Controllers;
public class HelloController : Controller   // Remember inheritance?    
{
    // [HttpGet] // We will go over this in more detail on the next page    
    // [Route("")] // We will go over this in more detail on the next page
    // public string Index()
    // {
    //     return "Hello World from HelloController!";
    // }

    [HttpGet("/")]
    public ViewResult Index()
    {
        //Interpret this line as a key:value pair
        ViewBag.ReaperUlt = "Overwatch";
        ViewBag.Number = 2;

        return View();
    }

    [HttpGet("/user/more")]
    public ViewResult OneUser()
    {
        ViewBag.StarWars = "Darth Vader";

        return View();
    }

    [HttpPost("process")]
    public IActionResult Process(string favoriteAnimal)
    {

        if(favoriteAnimal.ToLower() == "dog")
        {
            ViewBag.Error = "Dogs are a great pick but choose something else!";
            return View("Index");
        }

        return RedirectToAction("Index");
    }
}

