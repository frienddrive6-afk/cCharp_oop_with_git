namespace WarGame.Core.Models;


public abstract class Unit
{
    public virtual float Health { get; set; }

    public virtual float MaxHealth { get; set; }

    public virtual int Damage { get; set; }

    public virtual int Range { get; set; }

    public virtual int Position { get; set; }

    public virtual string? Symvol { get; set; }

    public virtual WhatArmy Side { get; set; }

    public Unit(WhatArmy side)
    {
        Side = side;
    }

    public virtual void Move()
    {
        if(Side == WhatArmy.LeftArmy)
        {
            Position++;
        }else
        {
            Position--;
        }
    }

    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
    }
    public abstract void Attack(Unit target);

    public int GetDistance(Unit target)
    {
        return Math.Abs(this.Position - target.Position);
    }

}