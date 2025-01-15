using backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class TournamentDbContext : DbContext
{
    public TournamentDbContext(DbContextOptions<TournamentDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Fighter>()
            .OwnsOne(fighter => fighter.Attributes);
    }

    private DbSet<Fighter> Fighters { get; set; }
}