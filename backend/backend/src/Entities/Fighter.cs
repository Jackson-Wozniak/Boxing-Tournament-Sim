using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Entities;

public class Fighter
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; }
    public Attributes Attributes { get; set; }

    public Fighter(string name, Attributes attributes)
    {
        Name = name;
        Attributes = attributes;
    }
}