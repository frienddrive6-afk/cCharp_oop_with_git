using System.IO.Compression;

namespace WarGame.Core.Models;

public class Army
{
    private List<Unit> units = new List<Unit>();

    public Army(WhatArmy whatArmy)
    {
        for (int i = 0; i < units.Count; i++)
        {
            units[i].Side = whatArmy;
        }   
    }    

    public void AddUnit(Unit unit)
    {
        units.Add(unit);
    }

    public void CleanupDead()
    {
        for(int i = units.Count - 1; i >= 0; i--)
        {
            if(units[i].Health <= 0) {
                units.RemoveAt(i);
            }
        }

        if (units.Count == 0)
        {
            Console.WriteLine("Армия полностью разбита!");
        }
    }

    public bool HasUnits => units.Count > 0;

    public List<Unit> GetUnits() => units;


    public void MoveUnits()
    {
        foreach (var unit in units)
        {
            unit.Move();
        }
    }


}