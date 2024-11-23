using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Director> Directors { get; set; }
        public Category Category { get; set; }
    }
}
