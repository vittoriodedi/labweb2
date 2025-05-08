using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models.Entities
{
    public class Sala
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int CapacitaPosti { get; set; }
        public List<Posto> Posti { get; set; } = new();
        public List<Proiezione> Proiezioni { get; set; } = new();
    }

}