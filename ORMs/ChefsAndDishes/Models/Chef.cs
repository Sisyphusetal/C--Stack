#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.Resources;

namespace ChefsAndDishes.Models;


public class Chef
{
    [Key]
    public int ChefId { get; set; }

    [Required(ErrorMessage = "You must enter a first name.")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "You must enter a last name.")]
    public string LastName { get; set; }
    [Required]
    [DataType(DataType.Date)]
    [Over18]
    public DateTime BirthDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Dish> AllDishes { get; set; } = new List<Dish>();

}
public class Over18Attribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        DateTime now = DateTime.Now;
        DateTime userInput = (DateTime)value;
        DateTime EighteenYearsAgo = DateTime.Now.AddYears(-18);

        if (userInput > EighteenYearsAgo)
        {
            return new ValidationResult("You must be over 18 to be a proper chef.");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}