#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
using System.ComponentModel.DataAnnotations;

namespace Recap.Models;

public class Username
{
    [Display(Name = "Username")]
    [Required(ErrorMessage = "Please enter a username")]
    [MinLength(2, ErrorMessage = "Username must be at least 2 characters")]
    public string Content { get; set; }
}