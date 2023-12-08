using BlazorMoviesApp.Components.Models;
using BlazorMoviesApp.Data;
using BlazorMoviesApp.Services;
using Microsoft.EntityFrameworkCore;

namespace BlazorMoviesApp.Services
{
    public class MovieReviewService : IMovieReviewService
    {
        private readonly MovieReviewDBContext movieReviewDBContext;

        public MovieReviewService(MovieReviewDBContext movieReviewDBContext)
        {
            this.movieReviewDBContext = movieReviewDBContext;
        }
        public async Task<MovieModel?> GetMovieById(int id)
        {
            return await movieReviewDBContext.Movies.SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<List<MovieModel>?> GetMovies()
        {
            return await movieReviewDBContext.Movies.ToListAsync<MovieModel>();
        }
    }
}
