using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        public int Year { get; set; }
        [Required]
        public bool Available { get; set; }
    }
}