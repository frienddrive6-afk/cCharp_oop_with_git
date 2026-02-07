#region СТРУКТУРЫ


// Point a = new Point(3, 4);

// User b = new User(101);

// Point c =  new Point(3, 4)
// {
//     x = 0,
//     y = 0,
// };


// Point a = new Point(3, 4);
// Point b;
// b = a;


// struct Point
// {

//     public int x = 100;
//     public int y = 100;

//     public Point(int x, int y)
//     {
//         this.x = x;
//         this.y = y;
//     }


//     public void Render()
//     {
//         System.Console.WriteLine($"{x}, {y}");
//     }
// }

// struct Vector;

// struct User(int id) {};


#endregion


#region ТИПЫ

//Значимые типы
// 1. Все целочисленные примитивные типы
// 2. Все типы с плавующей запятой
// 3. bool
// 4. enum
// 5. char
// 6. struct      <------!



// Ссылочные типы
// 1. Классы (string, object)
// 2. Интерфейсы
// 3. Делегат

// Unit a = new Unit();

// object b = new Unit();


// class Unit
// {
    
//     public void Render()
//     { }
// }



#endregion



#region ПРИМЕР_1

void Execute()
{
    Point a = new Point()
    {
        x =2,
        y = 3,
    };

    Unit b = new Unit()
    {
        x = 20,
        y = 30,
    };

    Point c = a;
    Unit d = b;



}


Execute();



struct Point
{
    public int x;
    public int y;
}


class Unit
{
    public int x;
    public int y;
}




#endregion




