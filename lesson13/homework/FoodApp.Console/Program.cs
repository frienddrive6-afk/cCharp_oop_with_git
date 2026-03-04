using FoodApp.Core.Bank;
using FoodApp.Core.Phone;
using FoodApp.Core.Models;
using FoodApp.Core.Strategies;
using FoodApp.Core.Abstracts;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Bank centralBank = new Bank();
Phone myPhone = new Phone("+380991112233");

BankCard myCard = new BankCard("User", "Dev", myPhone, 1000m);
myCard.LinkedEmail = "user@mail.com"; 
centralBank.AddBankCard(myCard);

Console.WriteLine("=== ВАШИ ДАННЫЕ (ДЛЯ ТЕСТА) ===");
Console.WriteLine($"Карта: {myCard.CardNumber}");
Console.WriteLine($"CVV: {myCard.CVV} | Срок: {myCard.ExpirationDate}");
Console.WriteLine($"Email: {myCard.LinkedEmail}");
Console.WriteLine($"Баланс: {myCard.Balance} грн.");
Console.WriteLine("===============================\n");

Order myOrder = new Order(750.00m);
Console.WriteLine($"Сумма вашего заказа: {myOrder.TotalPrice} грн.");

bool isPaid = false;

while (!isPaid)
{
    Console.WriteLine("\nВыберите способ оплаты:");
    Console.WriteLine("1 - Кредитная карта");
    Console.WriteLine("2 - PayPal");
    Console.WriteLine("3 - Наличными курьеру");
    Console.WriteLine("0 - Отмена заказа");
    
    Console.Write("\nВаш выбор: ");
    string? choice = Console.ReadLine();

    IPaymentStrategy? selectedStrategy = null;

    switch (choice)
    {
        case "1":
            selectedStrategy = new CreditCardPayment(centralBank);
            break;
        case "2":
            selectedStrategy = new PayPalPayment(centralBank);
            break;
        case "3":
            selectedStrategy = new CashPayment();
            break;
        case "0":
            Console.WriteLine("Заказ отменен. Возвращайтесь еще!");
            return;
        default:
            Console.WriteLine("Неверный выбор, попробуйте снова.");
            continue;
    }

    myOrder.SetStrategy(selectedStrategy);

    if (myOrder.Checkout())
    {
        isPaid = true;
        Console.WriteLine("\n[Система]: Заказ оплачен. Курьер уже выезжает!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n[Система]: Оплата не удалась. Попробуйте другой способ или проверьте данные.");
        Console.ResetColor();
    }
}

Console.WriteLine("\nСпасибо за покупку!");