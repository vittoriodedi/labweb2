// Services/TmdbService.cs
using System.Net.Http.Json;
using CinemaManager.Models;
using Microsoft.Extensions.Configuration;

namespace CinemaManager.Services;

public class TmdbService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly string _baseUrl;
    private readonly string _imageBaseUrl;
    
    public TmdbService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _apiKey = configuration["TMDB:ApiKey"] ?? throw new InvalidOperationException("API Key non configurata");
        _baseUrl = configuration["TMDB:BaseUrl"] ?? "https://api.themoviedb.org/3";
        _imageBaseUrl = configuration["TMDB:ImageBaseUrl"] ?? "https://image.tmdb.org/t/p/w500";
    }
    
    public string GetImageBaseUrl() => _imageBaseUrl;
    
    public async Task<TmdbSearchResponse> SearchMoviesAsync(string query, int page = 1)
    {
        if (string.IsNullOrWhiteSpace(query))
            return new TmdbSearchResponse { Results = new List<TmdbMovie>() };
        
        var encodedQuery = Uri.EscapeDataString(query);
        var url = $"{_baseUrl}/search/movie?api_key={_apiKey}&language=it-IT&query={encodedQuery}&page={page}&include_adult=false";
        
        try
        {
            var response = await _httpClient.GetFromJsonAsync<TmdbSearchResponse>(url);
            return response ?? new TmdbSearchResponse();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore nella ricerca film: {ex.Message}");
            return new TmdbSearchResponse();
        }
    }
    
    public async Task<Film> ConvertToFilmAsync(TmdbMovie tmdbMovie)
    {
        return new Film
        {
            Titolo = tmdbMovie.Title,
            Descrizione = tmdbMovie.Overview ?? string.Empty,
            PercorsoLocandina = tmdbMovie.GetFullPosterPath(_imageBaseUrl),
            DataUscita = ParseReleaseDate(tmdbMovie.ReleaseDate),
            InProgrammazione = false,
            // Puoi aggiungere il recupero di altri dettagli come il regista con chiamate API aggiuntive
        };
    }
    
    private DateTime ParseReleaseDate(string? releaseDate)
    {
        if (string.IsNullOrEmpty(releaseDate))
            return DateTime.Today;
            
        return DateTime.TryParse(releaseDate, out var date) ? date : DateTime.Today;
    }
}