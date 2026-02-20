using Game.Core.Entities;

namespace Game.Core.World;


public class Map
{
    public int Width { get; init; }
    public int Height { get; init; }
    
    public List<GameObject> _objects = new List<GameObject>();

    public Map(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public void AddObject(GameObject obj)
    {
        _objects.Add(obj);
    }

    public void Render()
    {
        Console.Clear(); 
        
        for (int y = 0; y <= Height; y++)
        {
            for (int x = 0; x <= Width; x++)
            {
                bool isWall = (x == 0 || x == Width || y == 0 || y == Height);

                if (isWall)
                {
                    Console.SetCursorPosition(x * 2, y);
                    Console.Write("🧱");
                }
                else
                {
                    Console.SetCursorPosition(x * 2, y);
                    Console.Write("  "); 
                }
            }
        }

        foreach(GameObject obj in _objects)
        {
            obj.Render();
        }
        
        Console.SetCursorPosition(0, Height + 1);
    }

    public bool CanMoveTo(int x, int y)
    {
        if (x <= 0 || x >= Width || y <= 0 || y >= Height)
        {
            return false;
        }

        foreach (var obj in _objects)
        {
            if (obj.PositionX == x && obj.PositionY == y)
            {
                return false; 
            }
        }

        return true; 
    }

}