namespace FoodApp.Core.Strategies;

using FoodApp.Core.Abstracts;
using FoodApp.Core.Bank;



public class PayPalPayment : IPaymentStrategy
{

    private Bank _bank;

    public PayPalPayment(Bank bank)
    {
        _bank = bank;
    }

    public override bool Pay(decimal amount)
    {

        string? email = "";

        while(true)
        {
            Console.WriteLine($"Перенаправление на PayPal (Сумма: {amount} грн)");
            Console.Write("Введите ваш PayPal Email: ");
            email = Console.ReadLine();

            if (email is not null && email.Contains("@mail.com"))
            {
                break;
            }   

        }

        

        if (_bank.PayByEmail(email, amount))
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PayPal: Оплата подтверждена!");
            Console.ResetColor();
            return true;
        }

        return false;
    }
}