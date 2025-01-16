using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Entities;

public class TournamentRound
{
    [Key, Column(Order = 0)]
    [MaxLength(100)]
    public string TournamentName { get; set; }
    
    [Key, Column(Order = 1)]
    public int Round { get; set; }
    
    [ForeignKey(nameof(TournamentName))]
    public Tournament Tournament { get; set; }

    public List<Matchup> Matchups { get; set; } = new List<Matchup>();
}