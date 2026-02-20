namespace Game.Core.Entities;

public class Tree : StaticObject
{
    public int Height { get; set; }

    public int WoodAmount { get; set; }

    public Tree(int x, int y, int height, int woodAmount, string symvol = "🌳") : 
        base(x, y, symvol)
    {
        Height = height;
        WoodAmount = woodAmount;
    }

}