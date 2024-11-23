using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Models
{
    public class Nationality
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Director Director { get; set; }
    }
}
