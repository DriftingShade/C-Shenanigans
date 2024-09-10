#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
using System.ComponentModel.DataAnnotations;

namespace Recap.Models;

public class Movie
{
    public int MovieId { get; set; }

    [Required(ErrorMessage = "Please enter a title.")]
    [MinLength(2, ErrorMessage = "Title must be at least 2 characters.")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Please enter a director.")]
    [MinLength(2, ErrorMessage = "Director must be at least 2 characters.")]
    public string Director { get; set; }
    [Required(ErrorMessage = "Please enter a genre.")]
    [MinLength(2, ErrorMessage = "Genre must be at least 2 characters.")]
    public string Genre { get; set; }
    [Required(ErrorMessage = "Please enter a release date.")]
    public DateTime? ReleaseDate { get; set; }
    [Required(ErrorMessage = "Please select a rating.")]
    [Range(0.1, 11, ErrorMessage = "Rating out of range")]
    public double? Rating { get; set; }
    [Required(ErrorMessage = "Please enter a duration.")]
    [Range(1, 1000, ErrorMessage = "Duration out of range")]
    public int? DurationInMinutes { get; set; }
}