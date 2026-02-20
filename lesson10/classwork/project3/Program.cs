

#region Наследование

//Ограничения:
// 1. Только одиночное наследование
// 2. В терминах с++ наследование public

// 3. Модификатор класса наследника ---> такой же или более строгий чем у базового
// internal class A
// {}

// public class B : A              //ERROR
// {}


// 4. Класс можно сделать sealed (запечатаным) (в терминах c++ ---> финализированый)
// sealed class A
// {}

// class B : A
// {}

// 5. Наследование от статического класса запрещено
// static class Tools
// {
//     static int level = 1;
//     static void Render() {}
// }

// class Manager : Tools       //ERROR
// {}













Admin admin = new Admin("vasia@mail.com", 34, "read");
admin.Render();



internal class User
{
    
    private string email = string.Empty;

    public string Email { get => email; set => email = value; }

    public int Age { get; set; }

    public User()
    {}


    public User(int age)
    {
        Age = age;
        System.Console.WriteLine("User(int age)");
    }

    public User(string email, int age) :
        this(age)                                       //Делегирование
    {
        Email = email;

        System.Console.WriteLine("User(string email, int age)");
    }

    public void Render()
    {
        System.Console.WriteLine($"Email: {Email}");
    }


}


internal class Admin : User
{
    
    public string Permissions { get; set; }

    public Admin(string email, int age, string permissions) :
        base(email, age)
    {
        Permissions = permissions;
        System.Console.WriteLine("Admin(string email, int age, string permissions)");
    }

    public Admin(string permissions)
    {
        Permissions = permissions;
    }

    public void Render()
    {
        base.Render();
        System.Console.WriteLine($"Email: {Email}");
    }



}






#endregion










