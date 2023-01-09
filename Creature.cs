namespace mtgtour;

public class Creature : Entity
{
    public Creature (string name, List<CreatureTypeEnum> types)
    {
        Name = name;
        Types = types;
    }
    
    public string Name { get; }

    public List<CreatureTypeEnum> Types { get; }

    public int GetReputation() {
        return 0;
    }
}
