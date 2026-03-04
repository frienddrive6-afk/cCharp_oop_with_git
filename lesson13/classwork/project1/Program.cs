


Archiver achiver = new Archiver(12);
achiver.Strategy = new ZipStrategy();

achiver.CreateAchive("project1.cs");
achiver.CreateAchive("project2.cs");
achiver.CreateAchive("project3.cs");

achiver.Strategy = new RarStrategy();

achiver.CreateAchive("project1.cs");
achiver.CreateAchive("project2.cs");
achiver.CreateAchive("project3.cs");
achiver.CreateAchive("project4.cs");


abstract class Strategy
{
    public abstract void Compress(string filePath);

    public abstract void Decompress(string filePath);

}

class ZipStrategy : Strategy
{
    public override void Compress(string filePath)
    {
        System.Console.WriteLine($"Compressing with Zip to {filePath}");
    }

    public override void Decompress(string filePath)
    {
        System.Console.WriteLine($"Decompressing with Zip to {filePath}");
    }


}

class RarStrategy : Strategy
{
    public override void Compress(string filePath)
    {
        System.Console.WriteLine($"Compressing with Rar to {filePath}");
    }

    public override void Decompress(string filePath)
    {
        System.Console.WriteLine($"Decompressing with Rar to {filePath}");
    }


}



class Archiver
{
    public int Level { get; set; }

    public Strategy Strategy { get; set; }

    public Archiver(int level)
    {
        Level = level;
    }

    public void CreateAchive(string filePath)
    {
        Strategy.Compress(filePath);
    }


}
