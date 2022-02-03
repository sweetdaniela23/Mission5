using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options)
        {
            //blank for now
        }

        public DbSet<MovieEntry> Entries { get; set; }
        public DbSet<Category> Categories { get; set; } //maybe put category

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId= 1, CategoryName="Drama"},
                new Category { CategoryId = 2, CategoryName = "Action" },
                new Category { CategoryId = 3, CategoryName = "Fantasy" },
                new Category { CategoryId = 4, CategoryName = "Romance" },
                new Category { CategoryId = 5, CategoryName = "Comedy" }
                );
            
            mb.Entity<MovieEntry>().HasData(

                new MovieEntry
                {
                    MovieID = 1,
                    CategoryId = 1,
                    Title = "Encanto",
                    Year = "2022",
                    DirectorFirstName = "Marbalble",
                    DirectorLastName = "Nonito",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Josh",
                    Notes = "This is a great movie!"
                },
                new MovieEntry
                {
                    MovieID = 2,
                    CategoryId = 2,
                    Title = "The Count of Monte Cristo",
                    Year = "1986",
                    DirectorFirstName = "Stephen",
                    DirectorLastName = "Spielberg",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Britti",
                    Notes = "MY FAVORITE"
                },
                new MovieEntry
                {
                    MovieID = 3,
                    CategoryId = 3,
                    Title = "Titanic",
                    Year = "1990",
                    DirectorFirstName = "Johnny",
                    DirectorLastName = "Appleseed",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Jonah",
                    Notes = "Don't cry."
                }
                );
        }
    }
}
