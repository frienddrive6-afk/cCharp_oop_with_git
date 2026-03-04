namespace FoodApp.Core.Strategies;

using FoodApp.Core.Abstracts;

public class CashPayment : IPaymentStrategy
{
    public override bool Pay(decimal amount)
    {
        System.Console.WriteLine($"Отлата курьеру: {amount} грн");
        Console.Write("Выдаете: ");
        string? userAmontStr = Console.ReadLine();
        decimal userAmont = Convert.ToDecimal(userAmontStr);
        return CurerPay(amount, userAmont);
    }

    public bool CurerPay(decimal amount, decimal userAmont)
    {
        if(userAmont >= amount)
        {
            return true;
        }else
        {
            return false;
        }
    }
}