#pragma warning disable CS8618

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace EntityLecture.Models;

public class Post
{
    //Best practice is that primary key should be name of class+key pascal case (PostId)
    [Key]
    public int PostId {get; set;}

    [Required]
    [MinLength(2, ErrorMessage="Must be at least 2 characters long.")]
    [MaxLength(40, ErrorMessage="Must be maximum 40 characters.")]
    public string Topic {get; set;}

    [Required]
    [MinLength(2, ErrorMessage="Must be at least 2 characters long.")]
    public string Body {get; set;}

    [Display(Name ="Enter URL here: ")]
    public string ImageUrl {get; set;}

    public DateTime CreatedAt {get; set;} = DateTime.Now;

    public DateTime UpdatedAt {get; set;} = DateTime.Now;

    public int UserId {get; set;}
    public User? Creator {get; set;}

    public List<UserPostLike> PostLikes = new List<UserPostLike>();
}