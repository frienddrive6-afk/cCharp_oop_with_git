namespace FoodApp.Core.Abstracts;


public abstract class IPaymentStrategy
{
    public abstract bool Pay(decimal amount);


} 