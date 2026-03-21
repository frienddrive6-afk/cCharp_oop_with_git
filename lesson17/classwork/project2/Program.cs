

// System.Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());


// // int result = a / b;
// // System.Console.WriteLine($"Result: {result}");

// if(b == 0)
// {
//     Console.WriteLine("На ноль делить нельзя");
// }else
// {
//     int result = a / b;
//     System.Console.WriteLine($"Result: {result}");
// }







// ======== try cath finally thow =========



// System.Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());


// try
// {
//     int result = a / b;
//     System.Console.WriteLine($"Result: {result}");
// }catch (NullReferenceException ex)
// {
//     System.Console.WriteLine("Null not allowed");
// }
// catch (Exception exp)
// {
//     System.Console.WriteLine(exp.Message);    
// }
// finally
// {
//     System.Console.WriteLine("Finally");
// }








// try
// {

//     throw new DivideByZeroException("Test exeption");

// }
// catch (Exception ex)
// {
    
//     System.Console.WriteLine($"Error: {ex.Message}");
// }

























void F4()
{
    int a = 0;
    int result = a / a;
    System.Console.WriteLine("End of F4()");
}




void F3()
{
    F4();
    System.Console.WriteLine("End of F3()");
}


void F2()
{
    F3();
    System.Console.WriteLine("End of F2()");
}




void F1()
{
    F2();
    System.Console.WriteLine("End of F1()");
}

F1();