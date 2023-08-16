#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.Resources;

namespace ChefsAndDishes.Models;


public class Dish
{
    [Key]
    public int DishId { get; set; }

    [Required(ErrorMessage = "You must enter a dish name.")]
    public string Name { get; set; }

    [Required]
    [Range(1,5)]
    public int Tastiness { get; set; }

    [Required(ErrorMessage = "You must enter a calorie count.")]
    [Range(0, 10000)]
    public int Calories { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public int ChefId { get; set; }
    public Chef? Creator { get; set; }
}