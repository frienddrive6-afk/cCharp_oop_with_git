namespace Game.Core.Entities;


public class Stone : StaticObject
{
    public int Durability { get; set;}

    public Stone(int x, int y, int durability, string symvol = "🪨") : 
        base(x, y, symvol)
    {
        Durability = durability;
    }
    
}