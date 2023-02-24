using Microsoft.EntityFrameworkCore;

namespace MovieCollection.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<MovieEntry> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
                );


            mb.Entity<MovieEntry>().HasData(

                new MovieEntry
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "The Dark Knight",
                    Year = 2008,
                    Director = "Cristopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "The best movie ever"

                },

                new MovieEntry
                {
                    MovieId = 2,
                    CategoryId = 2,
                    Title = "Hitch",
                    Year = 2005,
                    Director = "Andy Tennant",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""

                },

                new MovieEntry
                {
                    MovieId = 3,
                    CategoryId = 5,
                    Title = "The Phantom of the Opera",
                    Year = 1925,
                    Director = "Lon Chaney",
                    Rating = "UR",
                    Edited = false,
                    LentTo = "",
                    Notes = ""

                }
            );

        }
    }
}
