namespace Game.Core.Entities;

public class Unit : GameObject
{
    public string? Name { get; set; }

    public int Health { get; set; }
    public int Damage { get; set; }

    public Unit(int x, int y, string symvol, string name, int health, int damage) : 
        base(x, y, symvol)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public void Move(int dx, int dy)
    {
        this.PositionX = dx;
        this.PositionY = dy;
    }

    // public void Attack(Unit target)
    // {
    //     target.Health -= this.Damage;
    // }



}