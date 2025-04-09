namespace CinemaManager;

public class Film
{
    public int Id { get; set; }
    public string Titolo { get; set; } = string.Empty;
    public string? Descrizione { get; set; }
    public int DurataMinuti { get; set; }
}