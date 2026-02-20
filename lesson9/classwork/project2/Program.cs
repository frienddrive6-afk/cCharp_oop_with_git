
#region  Overloading
// // 1. Имя должно совпадать
// // 2.Другое количество параметров
// // 3. Типо и порядок параметров должны
// // 4. Модификация параметров



// class Container
// {
//     public void Method(int a, int b)
//     {   }

//     public void Method(int a,int b, int c)
//     {   }

//     public void Method(int a, string b)
//     {   }

//     public void Method(ref int a, int b)
//     {   }


// }


#endregion


#region  Static

User a = new User();
User b = new User();


Console.WriteLine($"{a.id} {b.id}");
System.Console.WriteLine($"MaxId = {User.MaxId}");
System.Console.WriteLine($"Count = {User.InstanceCount}");



class User
{
    //Статическое поле (НЕ является частью состояния обьекта)
    private static int maxId;

    //обычное поле оно является частью состояния обьекта
    public int id;

    //Статический конструктор (инициализирует статические поля и свойства)
    // 1.Нельзя использовать модификатор доступа
    // 2. Нет this
    // 3. Нельзя вызвать явно (вызывается автоматические при создании класса)
    static User()
    {
        MaxId = 100;
    }


    // Статические метод
    // 1. нет this
    // 2. Можно использовать только статические поля и свойства
    public static void ResetMaxId() => User.maxId = 101;

    //Статичесское свойсва
    public static int MaxId
    {
        get => User.maxId;
        set => User.maxId = value;
    }

    //Статическое автосвойство

    public static int InstanceCount { get; set; } = 0;

    //Обычный конструктор
    public User()
    {
        this.id = ++User.MaxId;
        User.InstanceCount++; 

    }

}








#endregion









