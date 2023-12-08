using BlazorMoviesApp.Components.Models;

namespace BlazorMoviesApp.Services
{
    public interface IMovieReviewService
    {
        List<MovieModel>? GetMovies();
        MovieModel? GetMovieById(int id);
    }
}
