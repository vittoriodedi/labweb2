namespace CinemaManager;

public class Spettacolo
{
    public int Id { get; set; }
    public int FilmId { get; set; }
    public Film Film { get; set; } = null!;
    public int SalaId { get; set; }
    public Sala Sala { get; set; } = null!;
    public DateTime Orario { get; set; }
}
