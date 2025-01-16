using System.ComponentModel.DataAnnotations;

namespace backend.Entities;

public class Tournament
{
    [Key]
    public string Name { get; set; }

    public int FighterCount { get; set; }

    public List<TournamentRound> TournamentRounds { get; set; } = new List<TournamentRound>();
    
    public Tournament() { }

    public Tournament(string name, List<Fighter> fighters)
    {
        Name = name;
        FighterCount = fighters.Count;
        TournamentRounds.Add(new TournamentRound(this, 1, fighters));
    }
}