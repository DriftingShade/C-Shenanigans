using Recap.Models;

namespace Recap.Interfaces;

public interface IMovieService
{
    List<Movie> GetMovies();
}