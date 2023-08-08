using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace DojoSurveyWithValidations.Models;

public class Survey
{
    [Required]
    [MinLength(2, ErrorMessage="Name requires at least 2 characters.")]
    public string Name {get; set;}

    [Required]
    public string Location {get; set;}

    [Required]
    public string FavoriteLanguage {get; set;}

    [MinLength(20, ErrorMessage="Comment is required to be at least 20 characters.")]
    public string Comments {get; set;}
}
