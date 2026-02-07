namespace homework.src.User;

using homework.src.Account;

public class User
{
    private string name;
    private List<Account> accounts;


    public User(string name)
    {
        this.name = name;
        accounts = new List<Account>();
    }

    public void AddAccount(string password)
    {
        accounts.Add(new Account(name,password));

    }

    public string GetName()
    {
        return name;
    }

    public void PrintAllAccounts()
    {
        int i = 0;
        foreach(Account account in accounts)
        {
            System.Console.Write($"{++i}) ");
            account.PrintInfo();
        }
    }

    public Account GetAccount(int index)
    {
        return accounts[index];
    }

    public Account GetAccountById(int id)
    {
        foreach(Account account in accounts)
        {
            if(account.GetId() == id)
            {
                return account;
            }
        }
        return new Account();
    }
}