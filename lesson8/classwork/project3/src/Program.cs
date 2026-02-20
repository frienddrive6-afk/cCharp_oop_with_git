#region Intro


// User a = new User();

// a.Id = 101;
// System.Console.WriteLine(a.Id);



// class User
// {
//     private int id;
//     private string email;

//     public int Id
//     {
//         get
//         {
//             return id;
//         }
//         set
//         {
//             id = value < 0 ? 0 : value;
//         }
//     }

//     public string Email
//     {
//         get
//         {
//             return email;
//         }
//         set
//         {
//             email = value;
//         }
//     }

//     public void Rander()
//     {
//         System.Console.WriteLine($"{Id}\t{Email}");
//     }

// }





#endregion



#region  Частичные свойства

// User user = new User();

// user.Email = "vasia@mail.com";
// // System.Console.WriteLine(User.Email);          //ERROR


// System.Console.WriteLine(user.Id);
// System.Console.WriteLine(user.Info);

// class User
// {
//     private int id;
//     private string email;

//     public int Id
//     {
//         get
//         {
//             return id;
//         }
//     }

//     public string Email
//     {
//         set
//         {
//             email = value;
//         }
//     }

//     public string Info
//     {
//         get
//         {
//             return $"{id}\t{email}";
//         }
//     }

//     public void Rander()
//     {
//         System.Console.WriteLine($"{Id}\t{email}");
//     }

// }




#endregion



#region модификаторы

// System.Console.WriteLine();

// class User
// {
//     private string email = "no_email";
//     private int age = 0;

//     public string Email
//     {
//         get
//         {
//             return email;
//         }
//         protected set                //Модификатор блока должен быть более строким (ограничивающим)
//         {
//             email = value;
//         }
//     }

//     // public int Age                   //ERROR (модификатор блока только у полного свойства)
//     // {
//     //     private get
//     //     {
//     //         return age;
//     //     }
//     // }


// }







#endregion



#region Авто Свойства

System.Console.WriteLine();

class User
{
    public int Id { get; set; }                  //авто свойсво

    public int Age { get; }


}






#endregion








