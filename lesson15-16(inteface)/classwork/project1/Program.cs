
#region Intro


// interface IRenderable { }
// interface IMovable { }
// interface ILoggable { }
// interface ILogger { }
// interface IShape { }

// Интерфейсы могут содержать
// 1. методы
// 2. Свойства
// 3. События
// 4. Индексаторы
// 5. Статика (константы) FROM C#8


// interface ILogger
// {
//     //нельзя писать поля
//     public const double PI = 3.1415;
//     public static int count = 0;

//     public void Log(string massege);

//     public string Path { get; set; }
// }














// Shape a = new Shape();

// IRenderable b = new Shape();
// b.Render();

// IRenderable c = new Unit();
// c.Render();

// public interface IRenderable
// {
//     private const double PI = 3.1415;
//     private static int count = 0;

//     private void Info()
//     {
//         Console.WriteLine("Info");
//     }
//     public void Render()
//     {
//         System.Console.WriteLine("Render");
//         System.Console.WriteLine(count);
//         Info();
//     }

//     public int Ratio { get => 0;}

//     public double Factor => PI;

//     public int Count
//     {
//         get => IRenderable.count;
//         set => IRenderable.count = value;
//     }

// }




// class Shape : IRenderable
// {

// }


// class Unit : IRenderable
// {
//     public void Info()
//     {

//     }
// }




#endregion







#region Practice


// Unit a  = new Unit();
// a.Render();

// IRendereble b = new Unit();
// b.Render();

// IRendereble c = new Mesh();
// c.WriteLogs();

// IRendereble d = new Unit();
// d.WriteLogs();

// Mesh e = new Mesh();
// // e.WriteLogs();                                            // НЕ НАСЛЕДОВАНИЕ




// interface IRendereble
// {

//     public void Render();
//     public void WriteLogs()
//     {

//         System.Console.WriteLine("IRenderevle.Logs");
//     }


// }


// class Unit : IRendereble
// {

//     public void Render()
//     {
//         System.Console.WriteLine("Unit.Render");
//     }

//     public void WriteLogs()
//     {
//         System.Console.WriteLine("Unit.Logs");
//     }

// }


// class Mesh :IRendereble
// {
//     public void Render()
//     {
//         System.Console.WriteLine("Mesh.Render");
//     }
// }











#endregion








#region Multiple implementation




// Db db = new Db();

// IWriteble a = new Db();
// a.Write();

// ICompareble b = new Db();
// b.Compare(null);



// IWriteble iw = new Db();


// if(iw is ICompareble ic)
// {
//     ic.Compare(null);
// }

// if(iw is Db db)
// {
//     db.Compare(null);
// }



// interface IWriteble
// {
    
//     public void Write();

// }


// interface ICompareble
// {
    
//     public bool Compare(object? obj);

// }


// class Db : IWriteble, ICompareble
// {
//     public void Write()
//     {
//         System.Console.WriteLine("Write to Db ....");   
//     }

//     public bool Compare(object? obj)
//     {
//         return true;
//     }


//     public void Save()
//     {
//         System.Console.WriteLine("db.Save()");
//     }

// }













#endregion





#region Explisit reazization (явная реализация)


// Неявная реализация (обычная класическая общая )
// 1. когда методы интерфейсов не комфликтуют
// 2. Может быть переопределена в наследниках

// Явная реализация
// 1. Когда есть явные конфликты и неоднозначнасть в именах / сигнатурах
// 2. НЕ может быть переопределена в наследниках


// Db db = new Db();
// db.Write();

// IWriteble a = new Db();
// a.Write();


// ISaver b = new FileManager();
// b.Write();

// FileManager c = new FileManager();
// c.Write();


// IWriteble d = new Db();
// d.Write();


// Db db = new Db();

// ((IWriteble)db).Write();

// if( db is IWriteble iw)
// {
//     iw.Write();
// }

// IWriteble w = db;
// w.Write();


// interface IWriteble
// {
    
//     public void Write();


// }

// interface ISaver
// {
    
//     public void Write();

// }


// class Db : IWriteble, ISaver
// {
//     // === общая неявная реализация(одна на все интерфейсы)
//     public void Write()
//     {
//         System.Console.WriteLine("Общая реализация");   
//     }

//     // === явная реализация
//     // 1. Не являются членами класса
//     // 2. Нельзя сделать public
//     void IWriteble.Write()
//     {
//         System.Console.WriteLine("Db.IWriteble.Write()");
//     }
//     void ISaver.Write()
//     {
//         System.Console.WriteLine("Db.Isaver.Save()");
//     }


// }


// class FileManager : ISaver
// {
    
//     public void Write()
//     {
//         System.Console.WriteLine("FileManager.Write()");
//     }

//     void ISaver.Write()
//     {
//         System.Console.WriteLine("FileManager.ISaver.Write()");
//     }

// }




#endregion





#region Intefface with inheritance

// Rect a = new Rect();
// a.Update();




// interface IRendereble
// {
    
//     public void Render();

//     public void Calc();
//     public void Update();



// }




// abstract class Shape() : IRendereble
// {
    
//     public abstract void Render();

//     public virtual void Calc() => System.Console.WriteLine("Shape.Calc()");

//     public void Update() => System.Console.WriteLine("Shape.Update()");

// }



// class Rect : Shape
// {
//     public override void Render() => System.Console.WriteLine("Rect.Render()");

//     public override void Calc() => System.Console.WriteLine("Rect.Calc()");

//     public new void Update() => System.Console.WriteLine("Rect.Update()");
// }














// interface IRenderable
// {
    
//     public void Render();

// }



// class Shape : IRenderable
// {
//     public void Render() => System.Console.WriteLine("Shape.Render()");
// }


// class Rect : Shape,IRenderable
// {
//     public new void Render() => System.Console.WriteLine("Rect.Render()");
// }











// Rect a = new Rect();
// a.Render();                 // 2

// Shape b = new Rect();
// b.Render();                 // 1

// IRenderable c = new Rect();
// c.Render();                 // 3

// IRenderable d = new Shape();
// d.Render();                 // 1


// interface IRenderable
// {
//     public void Render();
// }

// class Shape : IRenderable
// {
//     public void Render() => Console.WriteLine("1. Shape.Render()");
// }

// class Rect : Shape, IRenderable
// {
//     public new void Render() => Console.WriteLine("2. new Rect.Render()");
//     void IRenderable.Render() => Console.WriteLine("3. Explicit IRenderable.Render() from Rect");
// }


















#endregion






#region  Interface inheritance  



// IWritable a = new FileManager();
// a.Write();                              // 6

// IFileSaver b = new FileManager();
// b.Write();                              // 7
// b.Save();                               // 8

// IWritable c = new FileManager();
// // c.Save();        // ERROR
// if (c is IFileSaver ifs)
//     ifs.Save();                         // 8

// if (c is FileManager fm)
//     fm.Save();                          // 4



// interface IWritable
// {
//     // public void Write();
//     public void Write() => Console.WriteLine("1. default Write() from IWritable");
// }

// interface IFileSaver: IWritable
// {
//     // public void Save();
//     public void Save() => Console.WriteLine("2. default save() from IFileSaver");
//     public new void Write() => Console.WriteLine("3. new Write from IFileSaver");
// }

// class FileManager : IFileSaver
// {
//     public void Save() => Console.WriteLine("4. FileManager.Save");

//     public void Write() => Console.WriteLine("5. FileManager.Write");

//     void IWritable.Write() => Console.WriteLine("6. Explicit FileManager.IWritable.Write");
//     void IFileSaver.Write() => Console.WriteLine("7. Explicit FileManager.IFileSaver.Write");
//     void IFileSaver.Save() => Console.WriteLine("8. Explicit FileManager.IFileSaver.Save");
// }










#endregion








#region Genatic Interface

// Author a = new Author("101");

// User<string> b = new Author("102");

// IAuthentificator<string> c = new Admin("103");

// object d = new Author("104");


// interface IAuthentificator<T>
// {
    
//     public T Id { get; }

// }


// class User<T> : IAuthentificator<T>
// {
//     public T Id { get;}

//     public User( T id) => Id = id;
// }


// class Admin : IAuthentificator<string>
// {
//     public string Id {get;}

//     public Admin(string id)  => Id = id;

// }



// class Author : User<string>
// {
//     public Author(string id) : base(id) { }
// }







#endregion





#region  IComparable / Icomparevle<T>


// // List<int> nums = new List<int>() { 4, 7, 8, 3,2 ,52, 6, 2, 21, 345};
// // nums.Sort();
// // foreach(int num in nums)
// // {
// //     System.Console.WriteLine(num);
// // }
// // System.Console.WriteLine();


// List<User> users = new List<User>
// {
//     new User() {Id = 101, Email = "email1@mail.com", Age = 20},
//     new User() {Id = 102, Email = "email2@mail.com", Age = 30},
//     new User() {Id = 103, Email = "email3@mail.com", Age = 40},
//     new User() {Id = 104, Email = "email4@mail.com", Age = 50},
// };
// users.Sort(new UserAgeComparer(Direction.Desc));

// foreach (User user in users)
// {
//     System.Console.WriteLine(user);
// }
// System.Console.WriteLine();



// enum Direction
// {
//     Acs,
//     Desc
// }


// // class User : IComparable
// // {
    
// //     public int Id { get; set; }

// //     public string? Email { get; set; }

// //     public int Age { get; set; }

// //     public override string ToString()
// //     {
// //         return $"id: {Id}, email: {Email}, age: {Age}";
// //     }

// //     public int CompareTo(object? obj)
// //     {

// //         if (obj is User user && obj is not null)
// //         {
// //             return this.Id.CompareTo(user.Id);
// //         }else if(obj is null)
// //         {
// //             throw new NullReferenceException();
// //         }

// //         throw new ArgumentException("obj is not User");

// //     }

// // }



// class User : IComparable<User>
// {
    
//     public int Id { get; set; }

//     public string? Email { get; set; }

//     public int Age { get; set; }

//     public override string ToString()
//     {
//         return $"id: {Id}, email: {Email}, age: {Age}";
//     }

//     public int CompareTo(User? obj)
//     {

//         if(obj is null)
//         {
//             throw new NullReferenceException();
//         }

//         return this.Id.CompareTo(obj.Id);
//     }

// }



// class UserAgeComparer : IComparer<User>
// {
//     private Direction _direction = Direction.Acs;

//     public int Compare(User? x, User? y)
//     {
//         if (x is null || y is null)
//         {
//             throw new NullReferenceException();
//         }

//         return _direction == Direction.Acs ? x.Age - y.Age : y.Age - x.Age;

//         // return x.Age.CompareTo(y.Age);
//     }

//     public UserAgeComparer(Direction direction = Direction.Acs)
//     {
//         this._direction = direction;
//     }

// }




#endregion




#region  ICloneable




// Homework





#endregion






#region *****  invariance / convariance / contravariance


// ====== invariance =======


List<Animal> animals = new List<Animal>();

List<Dog> dogs = new List<Dog>();

// animals = dogs;             ERROR


class Animal {}
class Dog : Animal {}

class Cat : Animal {}





#endregion














