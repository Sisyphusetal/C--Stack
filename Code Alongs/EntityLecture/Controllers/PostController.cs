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
        List<Post> AllPosts = db.Posts.ToList();
        return View("AllPosts", AllPosts);
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

    [HttpGet("/posts/{postId}")]
    public IActionResult ViewPost(int postId)
    {
        Post post = db.Posts.FirstOrDefault(post => post.PostId == postId);
        if(post == null)
        {
            return RedirectToAction("Index");
        };

        return View("ViewPost", post);
    }

    [HttpGet("/posts/{postId}/edit")]
    public IActionResult Edit(int postId)
    {
        Post? post = db.Posts.FirstOrDefault(post => post.PostId == postId);

        if(post == null)
        {
            return RedirectToAction("Index");
        };

        return View("Edit", post);
    }

    [HttpPost("/post/{postId}/update")]
    public IActionResult Update(Post editPost, int postId)
    {
        if(!ModelState.IsValid)
        {
            return Edit(postId);
        }

        Post? post = db.Posts.FirstOrDefault(post => post.PostId == postId);

        if(post == null)
        {
            return RedirectToAction("Index");
        };

        post.Topic = editPost.Topic;
        post.Body = editPost.Body;
        post.ImageUrl = editPost.ImageUrl;
        db.Posts.Update(post);
        //Save changes requires after Update, save changes actually updates intiated query
        db.SaveChanges();

        return RedirectToAction("ViewPost", new {postId = postId});
    }

    [HttpPost("/posts/{postID}/delete")]
    public IActionResult Delete(int postId)
    {
        Post? post = db.Posts.FirstOrDefault(post => post.PostId == postId);
        db.Posts.Remove(post);
        db.SaveChanges();

        return RedirectToAction("Index");
    }
}
