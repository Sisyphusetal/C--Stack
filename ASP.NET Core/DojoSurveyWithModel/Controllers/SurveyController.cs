using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;
using System.Collections.Generic;

namespace DojoSurveyWithModel.Controllers;
public class SurveyController : Controller  
{
    public static List<Survey> Surveys = new List<Survey>();

    [HttpGet("/")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpGet("/info")]
    public ViewResult Info()
    {
        return View("Info", Surveys);
    }

    [HttpPost("/process")]
    public IActionResult Process(Survey survey)
    {
        if(ModelState.IsValid)
        {
            Surveys.Add(survey);
            return RedirectToAction("Info");
        }
        else{
            return View("Index");
        }
    }
}

