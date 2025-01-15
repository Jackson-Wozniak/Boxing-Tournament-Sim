using backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class TournamentDbContext : DbContext
{
    public TournamentDbContext(DbContextOptions<TournamentDbContext> options) : base(options) { }

    private DbSet<Fighter> Fighters { get; set; }
}