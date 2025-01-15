using backend.Enums;

namespace backend.Entities;

/*
 TODO: currently attributes are set to 50 but once implemented they should be generated randomly
*/
public class Attributes
{
    public int Power { get; set; }
    public int Offense { get; set; }
    public int Defense { get; set; }

    public Attributes(FighterBlueprint blueprint, SkillLevel skillLevel)
    {
        Power = 50;
        Offense = 50;
        Defense = 50;
    }

    public int Overall()
    {
        return 50;
    }
}