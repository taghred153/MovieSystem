using System.ComponentModel.DataAnnotations;

namespace MovieSystem.DTOs
{
    public class Update_Delete
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public List<MovieDto> movieDtos { get; set; }
        public NationalityDto nationalityDto { get; set; }
    }
}
