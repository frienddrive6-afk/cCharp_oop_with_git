#region  Начало

// // E e = new E();
// // e.Show();

// // D d = new D();
// // d.Show();

// // A a = new D();
// // a.Show();

// // B b = new E();
// // b.Show();


// // object o = new C();

// // A a = new C();
// // a.Show();

// D d = new E();
// d.Show();



// class A
// {
//     public virtual void Show() => Console.WriteLine("A.Show()");
// }

// class B : A
// {
// }


// class C : B
// {
//     public override void Show() => Console.WriteLine("C.Show()");
// }


// class D : C
// {
// }


// class E : D
// {
//     public override void Show() => Console.WriteLine("E.Show()");
// }








#endregion



#region Сокрытие/ hiting


// Admin admin = new Admin(101, "admin@mail.com");
// admin.Show();


// Admin admin = new Admin(101, "admin@mail.com");
// admin.Email = "chack@mail.com";
// admin.Show();


User user = new Admin(101, "admin@mail.com");
user.Email = "chack@mail.com";
user.Show();

if(user is Admin a)
{
    a.Show();
}

class User
{
    public readonly static int minAge = 18;
    public const double Pi = 3.14;
    public int Id { get; set; }

    public string Email { get; set; }

    public User(int id, string email)
    {
        Id = id;
        Email = email;
    }

    public void Show() => Console.WriteLine($"id:  {Id}");


}




class Admin : User
{
    public new readonly static int minAge = 30;
    public new const double Pi = 3.14234234;

    public new string Email
    {
        get => $"admin {base.Email}";
        set => base.Email = value;
    }

    public Admin(int id, string email) :
        base(id, email)
    {}

    public new void Show()
    {
        base.Show();
        Console.WriteLine($"email: {Email}");
    }
}






#endregion









