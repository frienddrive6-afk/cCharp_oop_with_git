
Console.WriteLine("=======================================\nКАЛЬКУЛЯТОР СКИДОК\n=======================================\n\n");

Console.Write("Введите сумму покупки (в монетах): ");
int countMonay = 0; 
int.TryParse(Console.ReadLine(), out countMonay);

bool isHaveDiskontCard = false;
Console.Write("Есть ли у вас карта лояльности? (+/-):");
string? input = Console.ReadLine();
if (string.Equals(input, "да", StringComparison.OrdinalIgnoreCase) || input == "+")
{
    isHaveDiskontCard = true;
}

if(countMonay > 0)
{
    System.Console.WriteLine("---------------------------------------\nРАСЧЕТ СКИДКИ\n---------------------------------------\n");
    System.Console.WriteLine($"Сумма покупики: {countMonay}мон");
    byte pocentOfSumm = 0;
    if(countMonay >= 1001 && countMonay <= 5000)
    {
        pocentOfSumm = 5;
    }else if(countMonay >= 5001 && countMonay <= 10000)
    {
        pocentOfSumm = 10;
    }else if(countMonay >= 10000)
    {
        pocentOfSumm = 15;
    }
    
    
    System.Console.WriteLine($"Скидка по сумме ({pocentOfSumm}%) : -{(float)countMonay / 100 * pocentOfSumm}мон");
    if(isHaveDiskontCard == true)
    {
        System.Console.WriteLine($"Бонус по карте (5%) : +{(float)countMonay / 100 * 5}мон");
        pocentOfSumm += 5;
    }else
    {
        System.Console.WriteLine($"Бонус по карте (0%) : -0мон");    
    }
    

    System.Console.WriteLine($"---------------------------------------\nОбщая скидка:    {pocentOfSumm}%\nИтоговая сумма:    {(float)countMonay - (float)countMonay / 100 * pocentOfSumm}мон\n=======================================");

}
