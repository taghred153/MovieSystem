using System.ComponentModel.DataAnnotations;

namespace MovieSystem.DTOs
{
    public class AddAll
    {
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<DirectorDto> directorDtos { get; set; }
        public CategoryDto categoryDto { get; set; }
    }
}
