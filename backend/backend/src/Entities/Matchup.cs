using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Entities;

public class Matchup
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    private long Id { get; set; }
    
    [ForeignKey(nameof(FighterOne))]
    public int FighterOneId { get; set; }
    public Fighter FighterOne { get; set; }

    [ForeignKey(nameof(FighterTwo))]
    public int FighterTwoId { get; set; }
    public Fighter FighterTwo { get; set; }

    [Required]
    public int Round { get; set; }

    [Required]
    [MaxLength(100)]
    public string TournamentName { get; set; }
    
    [ForeignKey(nameof(Round) + "," + nameof(TournamentName))]
    public TournamentRound TournamentRound { get; set; }
}