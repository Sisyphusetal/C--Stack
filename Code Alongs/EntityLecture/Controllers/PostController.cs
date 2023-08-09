// Using statements
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using EntityLecture.Models;
namespace EntityLecture.Controllers;

[SessionCheck]
public class PostController : Controller

{
    private readonly ILogger<PostController> _logger;
    private MyContext db;


    public PostController(ILogger<PostController> logger, MyContext context)
    {
        _logger = logger;
        db = context;
    }


    [HttpGet("/posts")]
    public IActionResult Index()
    {
        List<Post> AllPosts = db.Posts.ToList();
        return View("AllPosts", AllPosts);
    }

    [SessionCheck]
    [HttpGet("/posts/new")]
    public IActionResult NewPost()
    {
        return View("New");
    }

    [SessionCheck]
    [HttpPost("/posts/create")]
    public IActionResult CreatePost(Post newPost)
    {
        if (!ModelState.IsValid)
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
        if (post == null)
        {
            return RedirectToAction("Index");
        };

        return View("ViewPost", post);
    }

    [HttpGet("/posts/{postId}/edit")]
    public IActionResult Edit(int postId)
    {
        Post? post = db.Posts.FirstOrDefault(post => post.PostId == postId);

        if (post == null)
        {
            return RedirectToAction("Index");
        };

        return View("Edit", post);
    }

    [HttpPost("/post/{postId}/update")]
    public IActionResult Update(Post editPost, int postId)
    {
        if (!ModelState.IsValid)
        {
            return Edit(postId);
        }

        Post? post = db.Posts.FirstOrDefault(post => post.PostId == postId);

        if (post == null)
        {
            return RedirectToAction("Index");
        };

        post.Topic = editPost.Topic;
        post.Body = editPost.Body;
        post.ImageUrl = editPost.ImageUrl;
        db.Posts.Update(post);
        //Save changes requires after Update, save changes actually updates intiated query
        db.SaveChanges();

        return RedirectToAction("ViewPost", new { postId = postId });
    }

    [HttpPost("/posts/{postID}/delete")]
    public IActionResult Delete(int postId)
    {
        Post? post = db.Posts.FirstOrDefault(post => post.PostId == postId);
        db.Posts.Remove(post);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    // Name this anything you want with the word "Attribute" at the end
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
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
        }
    }
}
