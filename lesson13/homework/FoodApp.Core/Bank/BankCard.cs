namespace FoodApp.Core.Bank;

using FoodApp.Core.Strategies;
using FoodApp.Core.Phone;
public class BankCard
{

    public string Name { get; private set; }
    public string FirstName { get; private set; }

    public Phone NumberOfPhone { get; private set; }
    public string CardNumber { get; private set; }
    public string ExpirationDate { get; private set; }
    public string CVV { get; private set; }

    public decimal Balance { get; set; }

    public string? LinkedEmail { get; set; }

    // List<string> messegesToUser = new List<string>();

    public BankCard(string name, string firstName, Phone numberOfPhone, decimal balance = 0)
    {
        Name = name;
        FirstName = firstName;
        NumberOfPhone = numberOfPhone;

        CardNumber = GenareteCardNumber();
        ExpirationDate = GanareteDate();
        CVV = GanareteCVV();

        Balance = balance;
    }


    private string GenareteCardNumber()
    {
        string newCard = "";
        for(int i = 0; i < 4;++i)
        {
            for(int j = 0; j < 4; ++j)
            {
                newCard += Random.Shared.Next(0, 10).ToString();
            }
            newCard += " ";
        }

        return newCard;
    }

    private string GanareteDate()
    {
        string newDate = "";
        for(int i = 0; i < 2; ++i)
        {
            newDate += Random.Shared.Next(0, 10).ToString();
        }
        newDate += "/";

        newDate += Random.Shared.Next(0, 10).ToString();

        return newDate;
    }
    

    private string GanareteCVV()
    {
        return Random.Shared.Next(100, 999).ToString();
    }


}