namespace WarGame.Core.Models;


public class BattleField
{
    Army leftArmy;
    Army rightArmy;

    public int Size { get; set; }

    private int TurnCounter;
    public BattleField(int size)
    {
        Size = size;
        leftArmy = new Army(WhatArmy.LeftArmy);
        rightArmy = new Army(WhatArmy.RightArmy);
        TurnCounter = 0;
    }


    public void RunBattle()
    {
        while(leftArmy.HasUnits && rightArmy.HasUnits)
        {
            PlayTurn();
            Draw();
            Thread.Sleep(1000);
        }
    }

    public void PlayTurn()
    {
        TurnCounter++;
        
        // Ходят левые
        foreach (Unit unit in leftArmy.GetUnits().ToList())
        {
            if (unit.Health > 0) 
                ProcessUnitAction(unit, rightArmy);
        }

        // Ходят правые
        foreach (Unit unit in rightArmy.GetUnits().ToList())
        {
            if (unit.Health > 0) 
                ProcessUnitAction(unit, leftArmy);
        }

        leftArmy.CleanupDead();
        rightArmy.CleanupDead();
    }

    public void ProcessUnitAction(Unit actor, Army enemies)
    {
        Unit? closestEnemy = null;
        int closestDistance = int.MaxValue;

        foreach (Unit enemy in enemies.GetUnits())
        {
            int distance = actor.GetDistance(enemy);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy;
            }
        }

        if (closestEnemy != null)
        {
            if (closestDistance <= actor.Range)
            {
                actor.Attack(closestEnemy);
            }
            else
            {
                actor.Move(); 
            }
        }
    }


    public void Draw()
    {
        Console.Clear();
        Console.WriteLine($"--- ХОД {TurnCounter} ---");

        string[] field = new string[Size];
        for (int i = 0; i < Size; i++) field[i] = "";

        foreach (Unit u in leftArmy.GetUnits())
        {
            if (u.Position >= 0 && u.Position < Size) 
            {
                field[u.Position] += u.Symvol;
            }
        }

        foreach (var u in rightArmy.GetUnits())
        {
            if (u.Position >= 0 && u.Position < Size) 
            {
                field[u.Position] += u.Symvol; 
            }
        }

        for(int i = 0; i < Size; i++)
        {
            string cellContent = field[i] == "" ? "_ " : field[i] + " ";
            Console.Write(cellContent);
        }
        Console.WriteLine();
        
        Console.WriteLine($"Юнитов: L:{leftArmy.GetUnits().Count} vs R:{rightArmy.GetUnits().Count}");
    }


    public Army GetLeftArmy() => leftArmy;
    public Army GetRightArmy() => rightArmy;




}


