using System.Reflection.Metadata;

namespace Game.Core.Entities;

public class StaticObject : GameObject
{
    public bool IsPassable { get; set; }

    public virtual void Interact()
    {
        System.Console.WriteLine("Игрок стоит на одной клетке с объектом");
    }

    public StaticObject(int x, int y, string symvol) :
        base(x, y, symvol)
    {
        
    }

}