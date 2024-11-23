using Microsoft.AspNetCore.Mvc;
using MovieSystem.DTOs;
using MovieSystem.Repository.MovieRepository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepo _repo;

        public MovieController(IMovieRepo repo)
        {
            _repo = repo;
        }

        [HttpPost("AddAll")]
        public IActionResult AddAll(AddAll addAll)
        {
            _repo.AddAll(addAll);
            return Created();
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var res = _repo.GetAll();
            return Ok(res);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            try
            {
                var res = _repo.GetById(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
