namespace Game.Core.Entities;

public class GameObject
{
    public int PositionX { get; set; }
    public int PositionY { get; set; }

    public string Symvol { get; init; }

    // public ConsoleColor Color { get; init; }

    public virtual void Render()
    {
        Console.SetCursorPosition(PositionX * 2, PositionY);
        Console.Write(Symvol);
    }

    public GameObject(int x, int y, string symvol)
    {
        PositionX = x;
        PositionY = y;
        Symvol = symvol;
    }
}