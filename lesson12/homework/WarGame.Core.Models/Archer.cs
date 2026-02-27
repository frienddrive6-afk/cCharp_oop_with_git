namespace WarGame.Core.Models;

public class Archer : Ranged
{
    public Archer(WhatArmy side) :
        base(side)
    {
        this.Health = 30;
        this.Damage = 15;
        this.Ammunition = 5;
        this.Symvol = "🏹";
    }


}