using Microsoft.EntityFrameworkCore;

namespace MovieApi;

public class MovieReviewContext : DbContext
{
    public DbSet<MovieReview> MovieReviews { get; set; }

    public MovieReviewContext(DbContextOptions<MovieReviewContext> options)
        : base(options)
    {
    }
}
