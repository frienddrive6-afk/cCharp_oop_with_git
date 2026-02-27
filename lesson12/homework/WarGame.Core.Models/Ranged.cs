namespace WarGame.Core.Models;


public class Ranged : Unit
{
    public int Ammunition { get; set; }

    public Ranged(WhatArmy side) : 
        base(side)
    {
        Ammunition = 10;
        this.Range = 2;
    }

    public override void Attack(Unit target)
    {
        if(Ammunition > 0)
        {
            target.TakeDamage(Damage);
            Ammunition--;
        }
    }


}