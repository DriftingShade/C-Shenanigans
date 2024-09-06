#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
using System.ComponentModel.DataAnnotations;

namespace FormWithValidation.Models;

public class Knight
{
    [Display(Name = "What is your name?")]
    [Required(ErrorMessage = "Yo, I asked you your name!")]
    [MinLength(3, ErrorMessage = "Yo, your name must be at least 3 characters!")]
    public string Name { get; set; }
    [Display(Name = "What is your favorite color?")]
    [Required(ErrorMessage = "Yo, I asked you your favorite color!")]
    [MinLength(3, ErrorMessage = "Yo, your favorite color must be at least 3 characters!")]
    public string FavoriteColor { get; set; }
    [Display(Name = "What is the airspeed velocity of an unladen swallow?")]
    [Required(ErrorMessage = "Yo, I asked you the velocity of an unladen swallow!")]
    [Range(1, 201, ErrorMessage = "Yo, the velocity must be between 1 and 100!")]
    public int? AverageSpeed { get; set; }
}