
using Microsoft.AspNetCore.Mvc;
using MovieApi;

[ApiController]
[Route("api/movie-reviews")]
public class MovieReviewController : ControllerBase
{
    private readonly MovieReviewContext _context;

    public MovieReviewController(MovieReviewContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult AddMovieReview(MovieReview review)
    {
        try
        {
            _context.MovieReviews.Add(review);
            _context.SaveChanges();

            return Ok(review);
        }
        catch {
            return StatusCode(500);
        }
    }

    
    [HttpGet("{imdbId}")]
    public IActionResult GetMovieReviews(string imdbId)
    {
        var reviews = _context.MovieReviews
            .Where(r => r.ImdbId == imdbId)
            .ToList();

        return Ok(reviews);
    }

    [HttpGet]
    public IActionResult GetMovieReviews()
    {
        var reviews = _context.MovieReviews
           
            .ToList();

        return Ok(reviews);
    }
}
