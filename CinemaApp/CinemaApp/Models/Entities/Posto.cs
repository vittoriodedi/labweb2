using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models.Entities
{
    public class Posto
    {
        public int Id { get; set; }
        public string Fila { get; set; } = string.Empty;
        public int Numero { get; set; }
        public int SalaId { get; set; }
        public Sala Sala { get; set; } = null!;
        public List<Biglietto> Biglietti { get; set; } = new();
    }

}