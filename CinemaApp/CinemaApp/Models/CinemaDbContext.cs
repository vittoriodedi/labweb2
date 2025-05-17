using CinemaApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace CinemaApp.Models;

public class CinemaDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public CinemaDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
    }
    public DbSet<UserAccount> UserAccounts { get; set; }
    public DbSet<Film> Films { get; set; }
    public DbSet<Proiezione> Proiezioni { get; set; } = null!;
    public DbSet<Sala> Sale { get; set; } = null!;
    public DbSet<Posto> Posti { get; set; } = null!;
    public DbSet<Biglietto> Biglietti { get; set; } = null!;



}