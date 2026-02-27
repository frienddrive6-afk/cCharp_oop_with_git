//с++                                           с#
//чистая фиртуальная функция            абстрактный метод(является виртуальным) 
//австракный класс                      абстрактный класс
//интерфейсный класс                    интерфейс


//Абстрактные члены классы
//1. методы
//2. свойства
//3. События
//4. Индексаторы





// abstract class Unit
// {
    
//     public int Hp { get; protected set; }            //Автосвойство

//     public abstract int Force { get; set; }          // Не автосвойство поле не создается (разворачивается в два абстрактных метода)

//     public abstract int Points { get; set; }         // Не автосвойство поле не создается (разворачивается в два абстрактных метода)

//     public abstract void Defense();

//     public virtual void Move()
//     {
//         System.Console.WriteLine("Unit Move");
//     }

//     public void Attac()
//     {
//         System.Console.WriteLine("Unit Attac");
//     }

// }



// class Warrior : Unit
// {
//     public override int Force { get; set; }               //Автосвойство

//     private int _points;
//     public override int Points { 
//         get => _points;
//         set => _points = value; 
//     }

//     public override void Defense()
//     {
//         System.Console.WriteLine("Warrior Defense");
//     }

//     public override void Move()
//     {
//         System.Console.WriteLine("Warrior Move");
//     }

// }



// class SuperWarrior : Warrior
// {
//     public override void Defense()
//     {
//         System.Console.WriteLine("SuperWarrior Defense");
//     }

// }



// abstract class Archer : Unit
// {
    


// }



// =========== Object class virtual method 
Product p = new Product()
{
  Id = 101,
  Title = "Book",  
};
System.Console.WriteLine(p.ToString());


class Product
{
    public int Id { get; set; }
    public string Title { get; set; } = "no_title";

    public override string ToString() => $"Id: {Id}, Title: {Title}";

}