using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Microsoft.AspNetCore.Cors;
using MovieApi.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        // GET: api/movies
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            try
            {
                string assetFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Assets", "movies.json");
                string fileContent = System.IO.File.ReadAllText(assetFilePath);
                System.Console.WriteLine("File Content read");
                // Deserialize the file content into a list of movie objects
                List<Movie>? movies = JsonSerializer.Deserialize<List<Movie>>(fileContent);
                System.Console.WriteLine("Movies List Length" + movies?.Count);
                return Ok(movies ?? new List<Movie>());
            }
            catch (Exception e)
            {
                System.Console.WriteLine("In catch Looop");
                System.Console.WriteLine(e);
                return StatusCode(500, "An Error Occured while parsing movies");
            }
            // Return the movies list as the response
        }

        // GET api/movies/5
        [HttpGet("{id}")]
        public ActionResult<Movie> Get(string id)
        {
            try
            {
                string assetFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Assets", "movies.json");
                string fileContent = System.IO.File.ReadAllText(assetFilePath);
                // Deserialize the file content into a list of movie objects
                List<Movie>? movies = JsonSerializer.Deserialize<List<Movie>>(fileContent);
               
                System.Console.WriteLine("File Content Read");
                if (movies != null)
                {
                    return movies.Where((e) => e.Id == id).First();
                }
                else
                {
                    return StatusCode(StatusCodes.Status404NotFound, "Coudln't find movie with " + id);
                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return StatusCode(500, "Internal Server Error");
            }
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

