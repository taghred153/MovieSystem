using System.ComponentModel.DataAnnotations;

namespace MovieSystem.DTOs
{
    public class GeTByIdDto
    {
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<DirectorByIdDto> directorByIdDtos { get; set; }
        public CategoryDto categoryDto { get; set; }
    }
}
