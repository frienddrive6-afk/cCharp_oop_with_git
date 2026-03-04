namespace FoodApp.Core.Strategies;

using FoodApp.Core.Abstracts;
using FoodApp.Core.Bank;
public class CreditCardPayment : IPaymentStrategy
{
    private Bank _bank;
    public CreditCardPayment(Bank bank) {
        _bank = bank;
    }

    public override bool Pay(decimal amount)
    {
        Console.WriteLine($"Оплата картой на сумму {amount} грн");
        Console.Write("Введите номер карты (16 цифр): ");
        string? cardNumber = Console.ReadLine();

        if (cardNumber is null) 
        {
            return false;
        }else if(cardNumber.Replace(" ", "").Length != 16)
        {
            System.Console.WriteLine("Номер карты должен состоять из 16 цифр.");
            return false;
        }else
        {
            cardNumber = cardNumber.Replace(" ", "");
        }

        if (_bank.RequestSmsCode(cardNumber))
        {
            
            string? code = "";

            while (true) 
            {
                Console.Write("\nВведите 4-значный код из SMS (или 'view' для просмотра СМС): ");
                code = Console.ReadLine()?.Trim();

                if (code == "view")
                {
                    _bank.FindCard(cardNumber)?.NumberOfPhone.RenderMessages();
                    continue; 
                }

                if (code?.Length == 4 && int.TryParse(code, out _))
                {
                    break;
                }

                Console.WriteLine("Ошибка: Введите ровно 4 цифры или команду 'view'.");
            }


            if (_bank.VerifyAndPay(cardNumber, code, amount))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Оплата прошла успешно!");
                Console.ResetColor();
                return true;
            }
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Оплата отклонена. Проверьте данные или баланс.");
        Console.ResetColor();
        return false;
    }
}