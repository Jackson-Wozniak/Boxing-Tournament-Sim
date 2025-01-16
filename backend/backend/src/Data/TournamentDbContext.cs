using backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class TournamentDbContext : DbContext
{
    public TournamentDbContext(DbContextOptions<TournamentDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TournamentRound>()
            .HasKey(tr => new { tr.Round, tr.TournamentName });

        modelBuilder.Entity<TournamentRound>()
            .HasOne(tr => tr.Tournament)
            .WithMany(t => t.TournamentRounds)
            .HasForeignKey(tr => tr.TournamentName);

        // Relationships for Matchup
        modelBuilder.Entity<Matchup>()
            .HasOne(m => m.FighterOne)
            .WithMany()
            .HasForeignKey(m => m.FighterOneId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Matchup>()
            .HasOne(m => m.FighterTwo)
            .WithMany()
            .HasForeignKey(m => m.FighterTwoId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Matchup>()
            .HasOne(m => m.TournamentRound)
            .WithMany(tr => tr.Matchups)
            .HasForeignKey(m => new { m.Round, m.TournamentName });
        
        modelBuilder.Entity<Fighter>()
            .OwnsOne(fighter => fighter.Attributes);
    }

    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<TournamentRound> TournamentRounds { get; set; }
    public DbSet<Matchup> Matchups { get; set; }
    public DbSet<Fighter> Fighters { get; set; }
}