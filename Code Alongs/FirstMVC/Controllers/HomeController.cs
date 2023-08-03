﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public static List<Pet> Pets = new List<Pet>();
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    [HttpGet("/")]
    public IActionResult Index()
    {
        //If view is returned empty, it looks to the method name
        return View();
    }

    [HttpPost("/pet/create")]
    public IActionResult Create(Pet newPet)
    {

        if(ModelState.IsValid)
        {
            Pets.Add(newPet);
            return RedirectToAction("AllPets");
        }
        else{
            return View("Index");
        }

        
    }

    [HttpGet("/allpets")]
    public IActionResult AllPets()
    {
        return View("AllPets", Pets);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
