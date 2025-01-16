using System.ComponentModel.DataAnnotations;

namespace backend.Entities;

public class Tournament
{
    [Key]
    private string Name { get; set; }

    private int FighterCount { get; set; }

    public List<TournamentRound> TournamentRounds { get; set; } = new List<TournamentRound>();
    
    
}