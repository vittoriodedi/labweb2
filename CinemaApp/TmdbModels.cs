namespace CinemaManager.Models;

public class TmdbSearchResponse
{
    public int Page { get; set; }
    public List<TmdbMovie> Results { get; set; } = new();
    public int TotalPages { get; set; }
    public int TotalResults { get; set; }
}

public class TmdbMovie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? OriginalTitle { get; set; }
    public string? Overview { get; set; }
    public string? PosterPath { get; set; }
    public string? BackdropPath { get; set; }
    public string? ReleaseDate { get; set; }
    public List<int> GenreIds { get; set; } = new();
    public double? VoteAverage { get; set; }
    
    public string GetFullPosterPath(string baseUrl) => 
        !string.IsNullOrEmpty(PosterPath) ? $"{baseUrl}{PosterPath}" : string.Empty;
}