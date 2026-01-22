#region Вступление методы



//      [modifire] <return type> <method name>(<parameters>)
//      {
//          <body>
//      }


// int Add(int a, int b)
// {
//     return a + b;
// }




// //сокращенная форма (для одного стейтмана)


// int Add2(int a, int b) => a + b;



// //полная форма


// void RenderMessege(string messenge)
// {
//     System.Console.WriteLine($"Messege {messenge}");
// }


// //сокращенная форма

// void RenderMessege2(string messenge) => System.Console.WriteLine($"Messege {messenge}");


// int result = Add(23, 45);

// RenderMessege(result.ToString());
// RenderMessege($"{result}");


#endregion
        




#region  Параметры

// //Обязательные параметры

// void Render(string messege, int count)
// {
//     for(int i = 0; i < count;i++)
//     {
//         System.Console.WriteLine(messege);
//     }
// }


// Render("Vasia", 5);


// //Не обязательные параметры

// void Render2(string messege, int count = 3)
// {
//     for(int i = 0; i < count;i++)
//     {
//         System.Console.WriteLine(messege);
//     } 
// }

// Render2("Kolia");




// //Именованые параметры

// void Render(string messege = "no_massege", int count = 3, ConsoleColor color = ConsoleColor.Red)
// {
//     Console.ForegroundColor = color;
//     for(int i = 0; i < count;i++)
//     {
//         Console.WriteLine(messege);
//     }

//     Console.ResetColor();
// }

// Render("Kolia", 5, ConsoleColor.Green);

// Render(color: ConsoleColor.Yellow);

// Render("Vasia", color: ConsoleColor.Blue);






//=================== по-значению/по-ссылке ===================

// 1. по-начению
// void Render(int n)
// {
//     n *= 2;
//     System.Console.WriteLine($"Result {n}");
// }

// int val = 10;
// Render(val);
// Console.WriteLine($"val: {val}");








// 2. по-ссылке(ref)
// void Render(ref int n)
// {
//     n *= 2;
//     System.Console.WriteLine($"Result {n}");
// }

// int val = 10;
// Render(ref val);
// Console.WriteLine($"val: {val}");





//2.1 входной параметр (in)

// void RenderArea(in int w, in int h)
// {
    
//     int area = w * h;
//     Console.WriteLine($"Area: {area}");
// }




//2.3 выходной параметр (out)

// void CalcArea(int w, int h, out int area)
// {
//     area = w * h;
// }

// int area = 11;
// CalcArea(2, 4, out area);
// System.Console.WriteLine(area);




//=================== общий пример ===================

// bool CalcRectangle(in int w,in int h, out int area, out int perimetr)
// {
//     area = w * h;
//     perimetr = 2 * (w + h);
//     return true;
// }


// int w = 10;
// int h = 12;
// bool result = CalcRectangle(w, h, out int area, out int perimetr);
// System.Console.WriteLine($"Area: {area}");
// System.Console.WriteLine($"Perimetr: {perimetr}");



// 2.3  ref readonly (Начиная с .Net 12)

// void A(in int val) { }

// void B(ref readonly int val) { }

// int value = 12 ;

// A(42);
// A(value);

// B(ref readonly43);
// B(ref readonly value);







#endregion





#region Локальные функции


public class Program
{
    
    static void Main(string[] args)
    {
        int a = 45;
        int b =12;

        System.Console.WriteLine(Sum1());

        int Sum1() => a + b;

        static int Sum2() => a - b;                    //static не доступны внешние параметры
    }



}







#endregion




