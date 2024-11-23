using System.ComponentModel.DataAnnotations;

namespace MovieSystem.DTOs
{
    public class CategoryDto
    {
        [Required]
        public string Name { get; set; }
    }
}
