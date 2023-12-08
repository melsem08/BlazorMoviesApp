using BlazorMoviesApp.Components.Models;

namespace BlazorMoviesApp.Services
{
    public interface IMovieReviewService
    {
        Task<List<MovieModel>?> GetMovies();
        Task<MovieModel?> GetMovieById(int id);
    }
}
