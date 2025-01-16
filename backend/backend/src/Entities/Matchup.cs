using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Entities;

public class Matchup
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    private long Id { get; set; }
    
    [ForeignKey(nameof(FighterOne))]
    public long FighterOneId { get; set; }
    public Fighter FighterOne { get; set; }

    [ForeignKey(nameof(FighterTwo))]
    public long FighterTwoId { get; set; }
    public Fighter FighterTwo { get; set; }

    [Required]
    public int Round { get; set; }

    [Required]
    [MaxLength(100)]
    public string TournamentName { get; set; }
    
    [ForeignKey(nameof(Round) + "," + nameof(TournamentName))]
    public TournamentRound TournamentRound { get; set; }

    public Matchup(Fighter f1, Fighter f2, TournamentRound round)
    {
        TournamentName = round.TournamentName;
        TournamentRound = round;
        FighterOneId = f1.Id;
        FighterTwoId = f2.Id;
        FighterOne = f1;
        FighterTwo = f2;
    }
}