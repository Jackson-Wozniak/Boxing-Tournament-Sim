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
    
    public TournamentRound() { }

    public TournamentRound(Tournament tournament, int round, List<Fighter> fighters)
    {
        Tournament = tournament;
        TournamentName = tournament.Name;
        Round = round;
        fighters.Sort((f1, f2) => f1.CompareTo(f2));
        for (var i = 0; i < fighters.Count / 2; i++)
        {
            var matchup = new Matchup(fighters[i], fighters[fighters.Count - i - 1], this);
            Matchups.Add(matchup);
        }
    }
}