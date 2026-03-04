namespace FoodApp.Core.Bank;

public class Bank
{
    
    private List<BankCard> _bankCards = new List<BankCard>();
    private List<UserCMC> _usersCMS = new List<UserCMC>();
    public void AddBankCard(BankCard bankCard)
    {
        _bankCards.Add(bankCard);
    }

    public BankCard? FindCard(string cardNumder)
    {
        foreach(BankCard card in _bankCards)
        {
            if(card.CardNumber.Replace(" ", "") == cardNumder)
            {
                return card;
            }
        }

        return null;
    }


    private string GenareteCMCToUser()
    {
        return Random.Shared.Next(1000, 9999).ToString();        
    }



    public bool RequestSmsCode(string cardNumber)
    {

        BankCard? card = FindCard(cardNumber);
        if (card is not null)
        {
            string sms = GenareteCMCToUser();
            card.NumberOfPhone.GetSMS(sms);
            
            _usersCMS.RemoveAll(u => u.CardNumberCMC == card.CardNumber.Replace(" ", ""));
            _usersCMS.Add(new UserCMC(card.CardNumber.Replace(" ", ""), sms));
            return true;
        }
        return false;
    }


    public bool VerifyAndPay(string cardNumber, string userCode, decimal amount)
    {
        cardNumber = cardNumber.Replace(" ", "");
        
        BankCard? card = FindCard(cardNumber);

        UserCMC? record = _usersCMS.FirstOrDefault(u => u.CardNumberCMC == cardNumber);

        if(card is not null && record is not null)
        {
            if(record.CMS == userCode)
            {
                if(card.Balance >= amount)
                {
                    card.Balance -= amount;
                    _usersCMS.Remove(record);
                    return true;
                }
            }else
            {
                System.Console.WriteLine("Неверный код");
                return false;
            }
            
            System.Console.WriteLine("Недостаточно средств");
        }

        return false;

    }




    public bool PayByEmail(string email, decimal amount)
    {
        
        BankCard? card = _bankCards.FirstOrDefault(c => c.LinkedEmail == email);

        if(card is not null)
        {
            if(card.Balance >= amount)
            {
                card.Balance -= amount;
                return true;
            }

            System.Console.WriteLine("PayPal: Недостаточно средств");
        }else
        {
            System.Console.WriteLine("PayPal: Не удалось найти карту");
        }

        return false;



    }












}
