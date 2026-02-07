#region ПРИМЕР_2


// void Execude()
// {
//     Role a = new Role() { id = 101, level = 3};
//     User b = new User() {id = 1, role = new Role() { id = 102, level = 4}};

//     Role c = a;
//     User d = b;


// }

// Execude();


// struct Role
// {
//     public int id;     
//     public int level;      
// }

// class User
// {

//     public int id;
//     public Role role;

// }







#endregion



#region ПРИМЕР_3


// void Execute()
// {
//     Role a = new Role();
//     User b = new User();


//     Role c = a;
//     User d = b;

// }

// Execute();



// class Role
// {
//     public int id;     
//     public int level;      
// }

// struct User
// {

//     public int id;
//     public Role role;

// }





#endregion



#region ПРИМЕР_4

// void Execute()
// {
//     Data data = new Data() 
//     {
//         payload = new Payload() 
//         { 
//             protocol = new Protocol() 
//             { 
//                 title = "Name of protocol" 
//             } 
//         } 
//     };


// }

// Execute();

// class Protocol
// {
//     public string title;

// }

// class Payload
// {
//     public Protocol protocol;
// }

// struct Data
// {
//     public Payload payload;
// }



#endregion




#region Практика

// void Func1(Role role)
// { }

// void Func2(ref Role role)
// { }

// void Func3(User user)
// { }

// void Func4(ref User user)
// { }


// Role role = new Role();
// User user = new User();

// Func1(role);
// Func2(ref role);
// Func3(user);
// Func4(ref user);

// class Role
// {
    

// }


// struct User
// {
    

// }








#endregion 




#region Пример_5

// void Method1(Point p)
// {
//     p.x = 100;
// }

// void Method2(ref Point p)
// {
//     p = new Point(100, 100);
// }

// void Metho3(ref Point p)
// {
//     p.x = 300;
// }

// Point a = new Point(1, 1);
// a.Render();
// Method1(a);
// a.Render();

// System.Console.WriteLine("----------------------b----------------------");

// Point b = new Point(1, 1);
// b.Render();
// Method2(ref b);
// b.Render();


// System.Console.WriteLine("----------------------c----------------------");

// Point c = new Point(1, 1);
// c.Render();
// Metho3(ref c);
// c.Render();

// class Point
// {
//     public int x;
//     public int y;

//     public Point(int x, int y)
//     {
//         this.x = x;
//         this.y = y;
//     }



//     public void Render()
//     {
//         System.Console.WriteLine($"point: ({x}, {y})");
//     }


// }







#endregion







