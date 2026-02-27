namespace WarGame.Core.Models;

public class Melee : Unit
{
    
    public virtual float Armor { get; set; }         //0.1 - 0.8

    public override void TakeDamage(int damage)
    {
        base.Health -= ((float)damage * (1.0f - Armor));
    }

    public Melee(WhatArmy side) : 
        base(side)
    {
        this.Range = 1;
    }

    public override void Attack(Unit target)
    {
        target.TakeDamage(Damage);
    }


}

