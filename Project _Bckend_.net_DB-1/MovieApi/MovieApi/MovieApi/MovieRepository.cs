// MovieRepository.cs
using System.Collections.Generic;
using System.Linq;

namespace MovieApi
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public MovieRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Models.Movie> GetMovies()
        {
            return _dbContext.Movies.ToList();
        }
    }
}