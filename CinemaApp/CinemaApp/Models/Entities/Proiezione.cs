using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models.Entities
{
    public class Proiezione
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int FilmId { get; set; }
        [Required]
        public Film Film { get; set; } = null!;
        [Required]
        public int SalaId { get; set; }
        [Required]
        public Sala Sala { get; set; } = null!;
        [Required]
        public DateTime DataOra { get; set; }
        [Required]
        public decimal PrezzoBase { get; set; }
        [Required]
        public bool Attiva { get; set; } = true;
        [Required]
        public List<Biglietto> Biglietti { get; set; } = new();
    }

}