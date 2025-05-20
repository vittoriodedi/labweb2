using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models.Entities
{
    public class Posto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Fila { get; set; } = string.Empty;
        [Required]
        public int Numero { get; set; }
        [Required]
        public int SalaId { get; set; }
    }

}