using System.Collections.Generic;

namespace MovieApi;

public interface IMovieRepository
{
    IEnumerable<Models.Movie> GetMovies();
}

