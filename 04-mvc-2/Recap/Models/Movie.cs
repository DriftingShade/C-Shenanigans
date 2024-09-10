#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace Recap.Models;

public class Movie
{
    public int MovieId { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public string Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
    public double Rating { get; set; }
    public int DurationInMinutes { get; set; }
}