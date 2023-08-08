// Using statements
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EntityLecture.Models;
namespace EntityLecture.Controllers;
public class PostController : Controller
{
    private readonly ILogger<PostController> _logger;
    private MyContext db;
    // Add a private variable of type MyContext (or whatever you named your context file)

    private MyContext _context;
    // Here we can "inject" our context service into the constructor     
    // The "logger" was something that was already in our code, we're just adding around it   
    public PostController(ILogger<PostController> logger, MyContext context)
    {
        _logger = logger;
        // When our HomeController is instantiated, it will fill in _context with context
        // Remember that when context is initialized, it brings in everything we need from DbContext
        // which comes from Entity Framework Core
        db = context;

    }


    [HttpGet("")]
    public IActionResult Index()
    {
        // Now any time we want to access our database we use _context   
        // List<Post> AllPosts = _context.Posts.ToList();
        return View("AllPosts");
    }

    [HttpGet("/posts/new")]
    public IActionResult NewPost()
    {
        return View("New");
    }

    [HttpPost("/posts/create")]
    public IActionResult CreatePost(Post newPost)
    {
        if(!ModelState.IsValid) 
        {
            return View("New");
        }

        db.Posts.Add(newPost);
        db.SaveChanges();
        
        return RedirectToAction("Index");
    }
}
