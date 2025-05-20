using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models.Entities
{
    public class Sala
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; } = string.Empty;
        [Required]
        public int CapacitaPosti { get; set; }
        
    }

}