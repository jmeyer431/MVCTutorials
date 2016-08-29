using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie_JustinMeyer.Data;
using System;
using System.Linq;

namespace MvcMovie_JustinMeyer.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies
                if (context.Movie.Any())
                {
                    return; // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        Director = "Rob Reiner",
                        ReleaseDate = DateTime.Parse("1989-1-11"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        IMDB_Rating = -1.0,
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        Director = "Ivan Reitman",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "PG",
                        IMDB_Rating = 7.8,
                        Price = 8.99M                        
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        Director = "Ivan Reitman",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "PG",
                        IMDB_Rating = 6.5,
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        Director = "Howard Hawks",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "N",
                        IMDB_Rating = -1.0,
                        Price = 3.99M                        
                    }
                        );

                context.SaveChanges();
            }
        }
    }
}
