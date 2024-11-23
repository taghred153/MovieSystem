﻿using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
