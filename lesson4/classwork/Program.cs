#region Intro OOP

// User user =  new User();

// user.id = 101;
// user.email = "sHt4f@example.com";

// user.Render();



// class User
// {
//     public int id;
//     public string email;
//     public void Render()
//     {
//         System.Console.WriteLine($"User info: {id}, {email}");
//     }
// }









// User user =  new User();

// user.Render();

// user.id = 101;
// user.email = "sHt4f@example.com";

// user.Render();



// class User
// {

//     public int id = 100;
//     public string email = "no_email";
//     public void Render()
//     {
//         System.Console.WriteLine($"User info: {id}, {email}");
//     }
// }



#endregion



#region ctor

// System.Console.WriteLine("Hello");

// class User
// {
//     public int id;
//     public string email;

//     public User(int id = 0, string email = "no_email")
//     {
//         this.id = id;
//         this.email = email;
//         System.Console.WriteLine("First ctor");

//     }

//     public User(int id):
//         this(id, "no_email")
//     {
//         System.Console.WriteLine("Second ctor");
//     }

// }




//FROM C# 12 !!!
//--- Primary constructor (Первичный конструктор)


// System.Console.WriteLine("");
// class User(int id, string email)
// {
//     public User(int id) :
//         this(id, "no_email")
//     { }

//     public void Render() => System.Console.WriteLine($"User info: {id}, {email}");
// }





// System.Console.WriteLine();

// class Product(int a, int b, int c)
// {
//     public void Render() => System.Console.WriteLine($"Product info: {a}, {b}, {c}");

// }




#endregion


#region Initializer


// Unit a = new Unit("archer", 100)
// {
//     hp = 300,
//     title = "warrior",
// };

// a.Render();

// Logger logger = new Logger()
// {
//     filePath = "usr/bin/",
//     depth = 100,
// };


// class Unit
// {
//     public string title;
//     public int hp;

//     public Unit(string title, int hp)
//     {
//         this.title = title;
//         this.hp = hp;
//     }

//     public void Render() => System.Console.WriteLine($"Unit info: {title}, {hp}");

// }


// class Logger
// {
//     public required string filePath;
//     public bool recursive = false;
//     public int depth = 500;
//     public string level = "warning";


// }





#endregion


#region Decon (ЭТО НЕ ДЕСТРУКТОР !!!!)


// User a = new User(100, "asasdasdasd@mail.com");

// // (int id, string email) = a;
// // >>> EQALS <<<

// (_, string email) = a;

// class User
// {
//     private int id;
//     private string email;


//     public User(int id, string email)
//     {
//         this.id = id;
//         this.email = email;
//     }

//     public void Deconstruct(out int id, out string email)
//     {
//         id = this.id;
//         email = this.email;
//     }

// }





#endregion




#region НЕСКОЛЬКО ФАЙЛОВ

using classwork;

Role role = new Role(1, "admin");
role.Render();



#endregion
