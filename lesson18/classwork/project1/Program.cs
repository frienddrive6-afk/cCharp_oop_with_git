

#region exeptions


Account acc = new Account(1000);

try
{
    acc.Withdraw(2000);
}catch(AccountExeption ex)
{
    System.Console.WriteLine($"System error: {ex.Message}, your sum is {ex.Sum}");
}catch(AppExeption ex)
{
    System.Console.WriteLine($"System error: {ex.Message}");
}catch(Exception ex)
{
    System.Console.WriteLine($"Internal server error");
}finally
{
    System.Console.WriteLine("finally");
}



class AppExeption : Exception
{
    public AppExeption(string? message) :
        base(message)
    { }
}


class AccountExeption : AppExeption
{
    public int Sum { get; set; }

    public AccountExeption(string? message, int sum) :
        base(message)
    {
        Sum = sum;
    }

}


class Account
{
    public int Balance { get; set; }
    public Account( int sum) => Balance = sum;

    public void Withdraw(int sum)
    {
        if(sum > Balance)
        {
            try
            {
                if(sum > Balance)
                {
                    throw new AccountExeption("Сумма недоступна", sum);
                }


                Balance -= sum;

                System.Console.WriteLine("Сумма снята");
            }catch (AccountExeption ex)
            {
                System.Console.WriteLine("account exeption log handler");

                throw new AppExeption("App Error");
            }
        }
    }


}








#endregion






