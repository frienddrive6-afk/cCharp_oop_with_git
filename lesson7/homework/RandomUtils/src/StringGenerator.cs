namespace RandomUtils;

public static class StringGenerator
{
    public static string GetRandomString(int len, string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz")
    {
        char[] result = new char[len];
        for(int i = 0; i < len; ++i)
        {
            result[i] = chars[RandomUtils.NumberGenerator.GetRandomNumber(0, chars.Length)];
        }
        
        return new string(result);
    }


}