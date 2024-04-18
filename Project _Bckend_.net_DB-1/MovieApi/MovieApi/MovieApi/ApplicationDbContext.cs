// ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using MovieApi.Models;

namespace MovieApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(entity =>
            {
                // Set the table name
                entity.ToTable("Movies");

                // Set the primary key
                entity.HasKey(m => m.Id);

                // Configure other properties
                entity.Property(m => m.ImdbId).IsRequired();
                entity.Property(m => m.Popularity).IsRequired();
                entity.Property(m => m.Budget).IsRequired();
                entity.Property(m => m.Revenue).IsRequired();
                entity.Property(m => m.OriginalTitle).IsRequired();
                entity.Property(m => m.Cast).IsRequired();
                entity.Property(m => m.Homepage).IsRequired();
                entity.Property(m => m.Director).IsRequired();
                entity.Property(m => m.Tagline).IsRequired();
                entity.Property(m => m.Keywords).IsRequired();
                entity.Property(m => m.Overview).IsRequired();
                entity.Property(m => m.Runtime).IsRequired();
                entity.Property(m => m.Genres).IsRequired();
                entity.Property(m => m.ProductionCompanies).IsRequired();
                entity.Property(m => m.ReleaseDate).IsRequired();
                entity.Property(m => m.VoteCount).IsRequired();
                entity.Property(m => m.VoteAverage).IsRequired();
                entity.Property(m => m.ReleaseYear).IsRequired();
                entity.Property(m => m.BudgetAdj).IsRequired();
                entity.Property(m => m.RevenueAdj).IsRequired();
            });
        }
    }
}