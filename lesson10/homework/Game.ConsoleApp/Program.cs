using Game.Core.Entities;
using Game.Core.World;

Map map = new Map(10, 10);

Unit player = new Unit(5, 5, "🧟", "Player", 100, 10);

map.AddObject(new Stone(3, 3, 10));
map.AddObject(new Tree(8, 8, 10, 10));
map.AddObject(player); 

while (true)
{
    map.Render();
    
    ConsoleKeyInfo key = Console.ReadKey(true);
    
    int newX = player.PositionX;
    int newY = player.PositionY;

    if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow) newY--;
    if (key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow) newY++;
    if (key.Key == ConsoleKey.A || key.Key == ConsoleKey.LeftArrow) newX--;
    if (key.Key == ConsoleKey.D || key.Key == ConsoleKey.RightArrow) newX++;
    if (key.Key == ConsoleKey.Escape) break;

    if (map.CanMoveTo(newX, newY))
    {
        player.PositionX = newX;
        player.PositionY = newY;
    }
}

Console.Clear();
Console.WriteLine("Игра завершена.");