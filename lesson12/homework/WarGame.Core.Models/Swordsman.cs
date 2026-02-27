namespace WarGame.Core.Models;

public class Swordsman : Melee
{
    
    public Swordsman(WhatArmy side) : 
        base(side)
    {
        this.Health = 50;
        this.Armor = 0.3f;
        this.Damage = 15;
        this.Symvol = "⚔️";
    }


}