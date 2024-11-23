using System.ComponentModel.DataAnnotations;

namespace MovieSystem.DTOs
{
    public class MovieDto
    {
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public CategoryDto categoryDto { get; set; }
    }
}
