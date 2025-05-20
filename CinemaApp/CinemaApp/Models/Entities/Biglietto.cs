using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models.Entities
{
    public class Biglietto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProiezioneId { get; set; }
        [Required]
        public Proiezione Proiezione { get; set; } = null!;
        [Required]
        public int? PostoId { get; set; }
        [Required]
        public Posto? Posto { get; set; }
        [Required]
        public decimal PrezzoFinale { get; set; }
        [Required]
        public string? CodicePrenotazione { get; set; }
        [Required]
        public DateTime DataAcquisto { get; set; } = DateTime.Now;
        [Required]
        public string? EmailCliente { get; set; }
        [Required]
        
        public bool Utilizzato { get; set; } = false;
    }

}