using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public List<Movie> Movies { get; set; }
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }
    }
}
