using BlazorMoviesApp.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorMoviesApp.Data
{
    public static class SeedData
    {
        public static void AddMovies(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieModel>().HasData(
               new MovieModel
               {
                   Id = 1,
                   Title = "Highlander",
                   Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet.",
                   ImageUrl = "/images/movies/Highlander.png",
                   Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet. Aenean in pellentesque erat, at pretium nulla. Ut dui sem, viverra in porta vel, molestie nec mi.",
               }
            );
            modelBuilder.Entity<MovieModel>().HasData(
               new MovieModel
               {
                   Id = 2,
                   Title = "Godfather",
                   Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet.",
                   ImageUrl = "/images/movies/Godfather.png",
                   Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet. Aenean in pellentesque erat, at pretium nulla. Ut dui sem, viverra in porta vel, molestie nec mi.",
               }
            );
            modelBuilder.Entity<MovieModel>().HasData(
               new MovieModel
               {
                   Id = 3,
                   Title = "Last of the Mohicans",
                   Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet.",
                   ImageUrl = "/images/movies/LastOfTheMohicans.png",
                   Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet. Aenean in pellentesque erat, at pretium nulla. Ut dui sem, viverra in porta vel, molestie nec mi.",
               }
            );
            modelBuilder.Entity<MovieModel>().HasData(
               new MovieModel
               {
                   Id = 4,
                   Title = "Rear Window",
                   Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet.",
                   ImageUrl = "/images/movies/RearWindow.png",
                   Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet. Aenean in pellentesque erat, at pretium nulla. Ut dui sem, viverra in porta vel, molestie nec mi.",
               }
            );
            modelBuilder.Entity<MovieModel>().HasData(
               new MovieModel
               {
                   Id = 5,
                   Title = "Road House",
                   Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet.",
                   ImageUrl = "/images/movies/RoadHouse.png",
                   Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet. Aenean in pellentesque erat, at pretium nulla. Ut dui sem, viverra in porta vel, molestie nec mi.",
               }
            );
            modelBuilder.Entity<MovieModel>().HasData(
               new MovieModel
               {
                   Id = 6,
                   Title = "Star Treck IV",
                   Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet.",
                   ImageUrl = "/images/movies/StarTreck4.png",
                   Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent non tellus vel orci gravida imperdiet. Aenean in pellentesque erat, at pretium nulla. Ut dui sem, viverra in porta vel, molestie nec mi.",
               }
            );
        }
    }
}
