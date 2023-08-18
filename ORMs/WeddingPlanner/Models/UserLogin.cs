#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

[NotMapped]
public class LoginUser
{
    // No other fields!
    [Required]
    [Display(Name = "Email Address")]
    public string LoginEmail { get; set; }
    [Required]
    public string LoginPassword { get; set; }
}
