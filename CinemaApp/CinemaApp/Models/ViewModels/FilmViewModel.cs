using System.ComponentModel.DataAnnotations;
using CinemaApp.Models.Entities;

namespace CinemaApp.Models.ViewModels;

public class FilmViewModel
{
    [Required(ErrorMessage = "Il titolo è obbligatorio")]
    [MaxLength(100, ErrorMessage = "Il titolo non può superare i 100 caratteri")]
    public string Titolo { get; set; } = string.Empty;

    [Required(ErrorMessage = "La data di uscita è obbligatoria")]
    public DateOnly DataUscita { get; set; } = DateOnly.FromDateTime(DateTime.Today);

    [Required(ErrorMessage = "Il genere è obbligatorio")]
    [MaxLength(50, ErrorMessage = "Il genere non può superare i 50 caratteri")]
    public string Genere { get; set; } = string.Empty;

    [Required(ErrorMessage = "Il regista è obbligatorio")]
    [MaxLength(100, ErrorMessage = "Il regista non può superare i 100 caratteri")]
    public string Regista { get; set; } = string.Empty;

    [Required(ErrorMessage = "La durata è obbligatoria")]
    [Range(1, 1000, ErrorMessage = "La durata deve essere compresa tra 1 e 1000 minuti")]
    public int DurataMinuti { get; set; } = 90;

    [MaxLength(2000, ErrorMessage = "La trama non può superare i 2000 caratteri")]
    public string Trama { get; set; } = string.Empty;

    [Required(ErrorMessage = "L'URL della locandina è obbligatorio")]
    [MaxLength(250, ErrorMessage = "L'URL non può superare i 250 caratteri")]
    public string LocandinaUrl { get; set; } = string.Empty;

    public bool Adulti { get; set; } = false;

    [Required(ErrorMessage = "La valutazione è obbligatoria")]
    [Range(1, 5, ErrorMessage = "La valutazione deve essere compresa tra 1 e 5")]
    public int Valutazione { get; set; } = 3;

    // Converti da ViewModel a Model
    public Film ToFilm()
    {
        return new Film
        {
            Titolo = Titolo,
            DataUscita = DataUscita,
            Genere = Genere,
            Regista = Regista,
            DurataMinuti = DurataMinuti,
            Trama = Trama,
            LocandinaUrl = LocandinaUrl,
            Adulti = Adulti,
            Valutazione = Valutazione
        };
    }

    // Converti da Model a ViewModel
    public static FilmViewModel FromFilm(Film film)
    {
        return new FilmViewModel
        {
            Titolo = film.Titolo,
            DataUscita = film.DataUscita,
            Genere = film.Genere, 
            Regista = film.Regista,
            DurataMinuti = film.DurataMinuti,
            Trama = film.Trama ?? string.Empty,
            LocandinaUrl = film.LocandinaUrl,
            Adulti = film.Adulti,
            Valutazione = film.Valutazione
        };
    }
}