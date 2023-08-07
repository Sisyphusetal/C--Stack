using Microsoft.AspNetCore.Mvc;


namespace DojoSurvey.Controllers;
public class SurveyController : Controller  
{
    [HttpGet("/")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpGet("/info")]
    public ViewResult Info()
    {
        ViewBag.Name = TempData["name"];
        ViewBag.Location = TempData["location"];
        ViewBag.FavoriteLanguage = TempData["favoriteLanguage"];
        ViewBag.Comments = TempData["comments"];

        return View();
    }

    [HttpPost("/process")]
    public IActionResult Process(string name, string location, string favoriteLanguage, string comments)
    {
        TempData["name"] = name;
        TempData["location"] = location;
        TempData["favoriteLanguage"] = favoriteLanguage;
        TempData["comments"] = comments;

        return RedirectToAction("Info");
    }
}

