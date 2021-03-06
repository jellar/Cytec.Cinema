using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cytec.Cinema.Domain;
using Cytec.Cinema.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Cytec.Cinema.Persistence
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options): base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CinemaDbContext).Assembly);

            var screens = new List<Screen>
            {
                new Screen()
                {
                    Id = 1,
                    Name = "Screen 1",
                    ScreenCapacity = 50
                },
                new Screen()
                {
                    Id = 2,
                    Name = "Screen 2",
                    ScreenCapacity = 75
                },
                new Screen()
                {
                    Id = 3,
                    Name = "Screen 3",
                    ScreenCapacity = 100
                }
            };
            
            var movies = new List<Movie>()
            {
                new Movie
                {
                    Id = 1,
                    Title = "The Godfather",
                    Description =
                        "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                    RunningTime = new TimeSpan(3, 15, 0),
                    Price = 10
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Shawshank Redemption ",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    RunningTime = new TimeSpan(2, 30, 0),
                    Price = 10
                },
                new Movie
                {
                    Id = 3,
                    Title = "Schindler's List",
                    Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                    RunningTime = new TimeSpan(2, 10, 0),
                    Price = 10
                },
                new Movie
                {
                    Id = 4,
                    Title = "Raging Bull",
                    Description = "The life of boxer Jake LaMotta, whose violence and temper that led him to the top in the ring destroyed his life outside of it.",
                    RunningTime = new TimeSpan(2, 09, 0),
                    Price = 10
                }
            };
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
