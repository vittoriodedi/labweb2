using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models.Entities
{
    public class Proiezione
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; } = null!;
        public int SalaId { get; set; }
        public Sala Sala { get; set; } = null!;
        public DateTime DataOra { get; set; }
        public decimal PrezzoBase { get; set; }
        public bool Attiva { get; set; } = true;
        public List<Biglietto> Biglietti { get; set; } = new();
    }

}