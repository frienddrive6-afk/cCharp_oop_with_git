#region AutoProperties


// System.Console.WriteLine("print");
// class User
// {
//     public int Id {get; set;}

//     public int Age {get; private set;}

//     public string Password {get; set; } = "no+password";

//     public User(int id)
//     {
//         Id = id;
//     }


// }




#endregion



#region init block

// User user1 = new();

// User user2 = new("vasia@gmail.com");

// User user3 = new() { Email = "vasia@gmail.com" };

// User user4 = new() {Username = "chack_norris"};


// class User
// {
//     private string username;
//     public string Email { get; set; } = "no_email";
//     public string Username
//     {
//         get
//         {
//             return username;        
//         }        

//         init                        //Можно использовать в: определение дефолтного значения, инициализаторе, конструкторе
//         {
//             username = value;
//             Email = $"{username}@mail.com";
//         }
//     }

//     public string Role {get; init; } = "guest";

//     public string Password {get; } = "no_password";

//     public User()
//     { }

//     public User(string username)
//     {
//         Username = "const_defult_username";
//     }



// }







#endregion




#region Practice
// System.Console.WriteLine();

// User user = new();


// class User
// {
//     private int Id { get; } = 101;

//     public string Email { get; private set; }

//     public string Password { private get; init; } = "23423412312312";
//     public int Level { get; private init;}


//     public User()
//     {
//         Id = 202;
//         Email = "petya@mail.com";
//     }

// }


#endregion





#region BUNS


// class User
// {
//     private string email;
//     private string password;

//     public string Email
//     {
//         get=>email;
//         set=>email=value;
//     }
    
//     // public string Password
//     // {
//     //     get=>password;
//     // }

//     public string Password => password;

// }






#endregion





#region required

// // User a = new User();                //ERROR

// // User b User("vaia@mail.com");           //ERROR

// // User c = new User("petya@mail.com")        //ERROR
// // {
// //     Age = 23,
// // };

// User c = new User("petya@mail.com")        
// {
//     Age = 23,
//     Email = "petya@mail.com"
// };


// class User
// {
//     public required int Age { get; set; }

//     public required string Email { get; set; }

//     public User()
//     {   }


//     public User(string email)
//     {
//         Email = email;
//     }

// }






#endregion





#region field



// class User
// {
//     private int id;
//     public int Id 
//     { 
//         get => id;
//         set => id = value < 0 ? 0 : value; 
//     }

//     public string Email
//     {
//         get => field;
//         set => field = value;
//     }

// }





#endregion


