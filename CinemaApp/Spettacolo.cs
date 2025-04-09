namespace CinemaManager
{
    public class Spettacolo
    {
        public int Id { get; set; }  // Identificativo dello spettacolo
        public int FilmId { get; set; }  // Riferimento al film (relazione con Film)
        public int SalaId { get; set; }  // Riferimento alla sala (relazione con Sala)
        public string Orario { get; set; } = string.Empty;  // Orario dello spettacolo
        public string? Lingua { get; set; }  // Lingua dello spettacolo (facoltativo)
        public bool Is3D { get; set; }  // Indica se lo spettacolo è in 3D (0 o 1)
        public bool Sottotitoli { get; set; }  // Indica se ci sono sottotitoli (0 o 1)

        // Relazioni con altre entità (Film e Sala)
        public Film Film { get; set; }  // Relazione con Film
        public Sala Sala { get; set; }  // Relazione con Sala
    }
}