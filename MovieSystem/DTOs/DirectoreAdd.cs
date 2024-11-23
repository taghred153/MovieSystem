using System.ComponentModel.DataAnnotations;

namespace MovieSystem.DTOs
{
    public class DirectoreAdd
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
