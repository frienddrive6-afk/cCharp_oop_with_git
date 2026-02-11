namespace RandomUtils;



public static class NumberGenerator
{
    public static int GetRandomNumber(int min, int max)
    {
        return Random.Shared.Next(min, max);
    }
}