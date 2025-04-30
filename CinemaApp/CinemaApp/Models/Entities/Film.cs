using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models.Entities
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titolo { get; set; }
        [Required]
        public DateOnly DataUscita { get; set; }
        [Required]
        public string Genere { get; set; }
        [Required]
        public string? Regista { get; set; }
        [Required]
        public int DurataMinuti { get; set; }
        [Required]
        public string? Trama { get; set; }
        [Required]
        public string LocandinaUrl { get; set; }
        [Required]
        public bool Adulti { get; set; }
        [Required]
        [Range(1, 5)]
        public int Valutazione { get; set; }
    }
}

