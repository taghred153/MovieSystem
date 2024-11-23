using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieSystem.DTOs;
using MovieSystem.Repository.NationalityRepository;

namespace MovieSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityController : ControllerBase
    {
        private readonly INationalityRepo _repo;

        public NationalityController(INationalityRepo repo)
        {
            _repo = repo;
        }
        [HttpPost("Add")]
        public IActionResult Add(NationalityDto nationalityDto)
        {
            _repo.Add(nationalityDto);
            return Created();
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            try
            {
                _repo.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
