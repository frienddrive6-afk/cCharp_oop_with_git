using WarGame.Core.Models;

int fieldSize = 20;
BattleField battle = new BattleField(fieldSize);

for (int i = 0; i < 5; i++)
{
    Unit leftUnit = GetRandomUnit(WhatArmy.LeftArmy);
    leftUnit.Position = i; 
    battle.GetLeftArmy().AddUnit(leftUnit);

    Unit rightUnit = GetRandomUnit(WhatArmy.RightArmy);
    rightUnit.Position = (fieldSize - 1) - i;
    battle.GetRightArmy().AddUnit(rightUnit);
}

Console.WriteLine("Армии наняты! Нажмите любую клавишу для начала войны...");
Console.ReadKey();

battle.RunBattle();

Unit GetRandomUnit(WhatArmy side)
{
    int type = Random.Shared.Next(0, 3); // 0, 1, 2

    switch(type)
    {
        case 0:
            {
                return new Swordsman(side);
            }
        case 1:
            {
                return new Archer(side);
            }
        case 2:
            {
                return new Knight(side);
            }
        default:
            {
                return new Swordsman(side);
            }
    }
}