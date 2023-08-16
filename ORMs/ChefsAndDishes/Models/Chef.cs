#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.Resources;

namespace ChefsAndDishes.Models;


public class Chef
{
    [Key]
    public int DishId { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    [DataType(DataType.Date)]
    [UniqueBirthday]
    public DateTime BirthDate { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public class UniqueBirthdayAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Birthday is required!");
            }
        }
    }
}