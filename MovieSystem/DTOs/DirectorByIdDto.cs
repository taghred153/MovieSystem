using System.ComponentModel.DataAnnotations;

namespace MovieSystem.DTOs
{
    public class DirectorByIdDto
    {
        [Required]
        public string Name { get; set; }
        public NationalityDto nationalityDto { get; set; }
    }
}
