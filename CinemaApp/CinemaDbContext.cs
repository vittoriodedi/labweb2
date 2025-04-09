
namespace CinemaManager;

using Microsoft.EntityFrameworkCore;

public class CinemaDbContext : DbContext
{
    public CinemaDbContext(DbContextOptions<CinemaDbContext> options) 
        : base(options) { }

    public DbSet<Sala> Sale { get; set; }

    public DbSet<Film> Films { get; set; }
    
    public DbSet<Spettacolo> Spettacoli { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}