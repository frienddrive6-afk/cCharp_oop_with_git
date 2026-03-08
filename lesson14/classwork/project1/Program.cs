





public abstract class Behavior
{
    public abstract void Animate();

    public abstract void Attac();


}


public class LightBehavior : Behavior
{
    
    public override void Animate()
    {
        Console.WriteLine("Light animate");
    }

    public override void Attac()
    {
        Console.WriteLine("Light attac");
    }
}

public class StrongBehavior : Behavior
{
    
    public override void Animate()
    {
        Console.WriteLine("Strong animate");
    }

    public override void Attac()
    {
        Console.WriteLine("Strong attac");
    }


}



public class Bot
{
    
    public int Radius {get; set; }

    public int Speed {get; set; }

    public Behavior Behavior {get; set; }

    public void Activate()
    {
        Behavior.Animate();
        Behavior.Attac();
    }

}









