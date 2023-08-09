using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using EntityLecture.Models;
using System;
using System.Runtime.ExceptionServices;

namespace EntityLecture.Controllers;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;

    private MyContext db;

    public UserController(ILogger<UserController> logger, MyContext context)
    {
        _logger = logger;
        db = context;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        if (HttpContext.Session.GetInt32("UUID") != null)
        {
            return RedirectToAction("Index", "Post");
        }
        return View("Index");
    }

    [HttpPost("/register")]
    public IActionResult Register(User newUser)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }

        PasswordHasher<User> hashBrowns = new PasswordHasher<User>();
        newUser.Password = hashBrowns.HashPassword(newUser, newUser.Password);

        db.Users.Add(newUser);
        db.SaveChanges();

        HttpContext.Session.SetInt32("UUID", newUser.UserId);

        return RedirectToAction("Index", "Post");
    }


    [HttpPost("/login")]
    public IActionResult Login(LoginUser userSubmission)
    {
        if (!ModelState.IsValid)
        {
            return View("index");
        }

        User userInDb = db.Users.FirstOrDefault(e => e.Email == userSubmission.LoginEmail);
        if (userInDb == null)
        {
            ModelState.AddModelError("LoginEmail", "Invalid Email Address");
            return View("Index");
        }

        PasswordHasher<LoginUser> hashBrowns = new PasswordHasher<LoginUser>();

        var result = hashBrowns.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LoginPassword);
        if (result == 0)
        {
            ModelState.AddModelError("LoginEmail", "Ah, ah, ah; Not the right password! Ah, ah, ah; Not the right password!");
            return View("Index");
        }

        //Successful login
        HttpContext.Session.SetInt32("UUID", userInDb.UserId);

        return RedirectToAction("Index", "Post");
    }

    [HttpPost("/logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
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
