namespace WarGame.Core.Models;

public class Crossbowman : Ranged
{
    public Crossbowman(WhatArmy side) :
        base(side)
    {
        this.Health = 60;
        this.Damage = 25;
        this.Range = 3;
        this.Ammunition = 5;
        this.Symvol = "🎯";
    }
}