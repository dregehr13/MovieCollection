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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieEntry>().HasData(

                new MovieEntry
                {
                    MovieId = 1,
                    Category = "Action/Adventure",
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
                    Category = "Comedy",
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
                    Category = "Horror/Suspense",
                    Title = "The Phantom of the Opera",
                    Year = 1925,
                    Director = "Lon Chaney",
                    Rating = "UR",
                    Edited = false,
                    LentTo = "",
                    Notes = ""

                }
            ) ; 
    
        }
    }
}
