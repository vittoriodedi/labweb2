using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models.Entities
{
    public class Biglietto
    {
        public int Id { get; set; }
        public int ProiezioneId { get; set; }
        public Proiezione Proiezione { get; set; } = null!;
        public int? PostoId { get; set; }
        public Posto? Posto { get; set; }
        public decimal PrezzoFinale { get; set; }
        public string? CodicePrenotazione { get; set; }
        public DateTime DataAcquisto { get; set; } = DateTime.Now;
        public string? EmailCliente { get; set; }
        public bool Utilizzato { get; set; } = false;
    }

}