namespace FoodApp.Core.Bank;


public class UserCMC
{

    public string CardNumberCMC { get; init; }

    public string CMS { get; init; }

    public UserCMC(string cardNumber, string CMS)
    {
        CardNumberCMC = cardNumber;
        this.CMS = CMS;
    }

}