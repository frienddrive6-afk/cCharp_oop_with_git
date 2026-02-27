namespace WarGame.Core.Models;


public class Knight : Melee
{
    public Knight(WhatArmy side) :
        base(side)
    {
        this.Health = 100;
        this.Armor = 0.5f;
        this.Damage = 20;
        this.Symvol = "🏇";
    }

    public override void Move()
    {
        if (Side == WhatArmy.LeftArmy)
        {
            Position += 1;
        }
        else
        {
            Position -= 1;
        }
    }

}