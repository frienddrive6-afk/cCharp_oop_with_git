namespace FoodApp.Core.Models;

using FoodApp.Core.Abstracts;
public class Order
{
    public decimal TotalPrice;

    public IPaymentStrategy? _strategy;

    public Order(decimal totalPrice)
    {
        TotalPrice = totalPrice;
    }

    public void SetStrategy(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public bool Checkout()
    {
        if(_strategy is not null)
        {
            return _strategy.Pay(TotalPrice);
        }
        System.Console.WriteLine("Выберите способ оплаты");
        return false;
    
    }

}