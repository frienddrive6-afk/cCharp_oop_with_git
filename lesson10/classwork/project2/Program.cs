


// string? name = null;





// void Render(string? str)
// {
//     if(str == null)
//     {
//         System.Console.WriteLine("Null");
//     }else
//     {
//         System.Console.WriteLine(str);
//     }
// }


// string? input = null;
// Render(input);











// void Render(string str)
// {
//     System.Console.WriteLine(str.ToLower());
// }


// string? input = null;
// Render(input);







// int t = 34;

// int? k = null;

// Nullable<int> k1 = null;






//============== null guard ========================

// void Render(string? message)
// {
//     if(message == null)
//     {
//         return;
//     }
//     System.Console.WriteLine(message);
// }



// void Render(string? message)
// {
//     if(message is null)
//     {
//         return;
//     }
//     System.Console.WriteLine(message);
// }




// void Render(string? message)
// {
//     if(message is not null)
//     {
//         System.Console.WriteLine(message);
//     }
// }



// void Render(string? message)
// {
//     if(message is string)
//     {
//         System.Console.WriteLine(message);
//     }
    
// }








// ============== null union =======================

// System.Console.Write("Enter your name: ");

// // 1.
// // string? input = Console.ReadLine();
// // string val = input ?? "no_name";

// // 2.
// // string? input = Console.ReadLine() ?? "no_name";


// // 3.
// string? input = Console.ReadLine();

// input ??= "no_name";                     // input = input ?? "no_name"

// System.Console.WriteLine($"Hello {input}");



// ============= условный null ===============


// void Process(User? user)
// {
//     // if(user is not null && user.Role is not null && user.Role.Title is not null)
//     // {
//     //     user.Role.Render();
//     // }

//     user?.Role?.Render();
// }


// class Role
// {
//     public string? Title { get; set; }

//     public void Render() => System.Console.WriteLine($"Tiltle = {Title}");

// }



// class User
// {
//     public Role? Role {get; set;}
// }








// ============= null-forgiven ===============



// class User
// {
//     public string Email {get; set;} = null!;

// }



// string? input  = null;

// Render(input!);

// void Render(string message)
// {
//     System.Console.WriteLine(message);
// }






// #nullable disable
// string value = null;
// #nullable enable






