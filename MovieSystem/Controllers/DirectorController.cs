using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieSystem.DTOs;
using MovieSystem.Repository.DirectorRepository;

namespace MovieSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorRepo _repo;

        public DirectorController(IDirectorRepo repo)
        {
            _repo = repo;
        }
        [HttpPost("Add")]
        public IActionResult Add(DirectorDto directorDto)
        {
            _repo.Add(directorDto);
            return Created();
        }
        [HttpPut("Update")]
        public IActionResult Update(int id, Update_Delete update_Delete)
        {
            try
            {
                _repo.Update(id, update_Delete);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
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
