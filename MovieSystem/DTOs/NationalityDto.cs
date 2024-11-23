using System.ComponentModel.DataAnnotations;

namespace MovieSystem.DTOs
{
    public class NationalityDto
    {
        [Required]
        public string Name { get; set; }
    }
}
