using Microsoft.EntityFrameworkCore;
using BlazorMoviesApp.Components.Models;

namespace BlazorMoviesApp.Data
{
    public class MovieReviewDBContext:DbContext
    {
        public MovieReviewDBContext(DbContextOptions<MovieReviewDBContext> options):base(options)
        {
             
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData.AddMovies(modelBuilder);
        }
    public DbSet<MovieModel> Movies { get; set; }
    }
}
