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

    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }
}

