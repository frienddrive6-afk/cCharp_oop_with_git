namespace MathEngine.Execution;

public class Calculator
{

    public int Execute(int a, int b, Operation op ) => op switch
    {
        Operation.Add => a + b,
        Operation.Subtract => a - b,
        Operation.Multiplycation => a * b,
        Operation.Divide => a / b,
    };


}
