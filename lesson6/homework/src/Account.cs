namespace homework.src.Account;


public class Account
{
    private int id;
    private string name;
    private string password;

    private decimal balance;

    private static int _nextId = 1;

    public Account(string name, string password,decimal balance = 0m)
    {
        if(name == "" || password == "")
        {
            throw new ArgumentException("Name and password cannot be empty");
        }

        if(balance < 0)
        {
            throw new ArgumentException("Balance cannot be negative");
        }

        this.id = _nextId++;
        this.name = name;
        this.password = password;
        this.balance = balance;


    }
    public Account()
    {
        this.id = -1;
        this.name = "";
        this.password = "";
        this.balance = 0m;

    }




    public void Deposit(decimal amount)
    {
        if(amount >= 0)
        {
            this.balance += amount;
        }else
        {
            Console.WriteLine("Wrong amount");
        }
    }

    public bool Withdraw(decimal amount, string password)
    {
        if(password != this.password)
        {
            System.Console.WriteLine("Wrong password");
            return false;
        }


        if(amount < 0)
        {
            System.Console.WriteLine("Wrong amount");
            return false;
        }

        if(this.balance < amount)
        {
            System.Console.WriteLine("Not enough money");
            return false;
        }

        this.balance -= amount;
        return true;
    }

    public bool Transfer(Account target, decimal amount, string password)
    {
        if(this.Withdraw(amount, password) == true)
        {
            target.Deposit(amount);
            return true;
        }

        return false;
    }


    public void PrintInfo()
    {
        Console.WriteLine($"Счет #{id} | Владелец: {name} | Баланс: {balance}");
    }

    public string GetName()
    {
        return name;
    }

    public decimal GetBalance()
    {
        return balance;
    }


    public int GetId()
    {
        return id;
    }
}