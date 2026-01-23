using System.Threading;

const string Digits = "0123456789";
const string LowerCase = "abcdefghijklmnopqrstuvwxyz";
const string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
const string SpecialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";

short lens;

PasswordSettings settings = new PasswordSettings();

InputUserData(out lens, ref settings);


while(ChekParametrs(settings) == false)
{
    InputUserData(out lens, ref settings);
}


string finalPassword;
bool isValid;
int iterator = 0;

do 
{
    finalPassword = GeneratePassword(lens, settings);

    isValid = CheckUserNeedPassord(finalPassword, settings);
    iterator++;

} while (isValid == false);

Console.Write($"Ваш пароль: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write((string)finalPassword);
Console.ResetColor();
Console.WriteLine($" был создан за {iterator} попытоки");


























void InputUserData(out short lens,ref PasswordSettings settings)
{
    lens = 0;

    while(lens < 4)
    {
        Console.Write("Введите длину паролья(минимум 4): ");
        string? input = Console.ReadLine();
        if (short.TryParse(input, out lens) == false || lens < 4)
        {
            Console.WriteLine("Ошибка! Нужно число >= 4.");
            Console.Write("Время что бы прочитать ");
            for(int i = 0; i < 4; ++i)
            {
                Thread.Sleep(700);
                Console.Write(".");
            }
            Console.Clear();
            continue;
            
        }
        else
        {
            break;
        }
    }

    Console.Write("Включить цифры? (y/n): ");
    if (Console.ReadLine()?.ToLower().Trim() == "y")
    {
        settings.useNums = true;
    }   

    Console.Write("Включить строчные буквы? (y/n): ");
    if (Console.ReadLine()?.ToLower().Trim() == "y")
    {
        settings.UseLowerCase = true;
    } 

    Console.Write("Включить прописные буквы? (y/n): ");
    if (Console.ReadLine()?.ToLower().Trim() == "y")
    {
        settings.useBigBuckvu = true;
    } 

    Console.Write("Включить специальные символы? (y/n): ");
    if (Console.ReadLine()?.ToLower().Trim() == "y")
    {
        settings.useSpecialChar = true;
    } 
}




bool ChekParametrs(in PasswordSettings settings)
{
    if(settings.useNums == false && settings.UseLowerCase == false && settings.useBigBuckvu == false && settings.useSpecialChar == false)
    {
        Console.Clear();
        Console.WriteLine("Вы не выбрали ни один символ для генерации пароля попробуйте ещё раз");
        return false;
    }
    else
    {
        return true;
    }

}


string CreateSourceString(in PasswordSettings settings)
{
    List<string> selectedSets = UserChoiseSimvolse(settings);


    int maxLen = MaxLenInListStrings(selectedSets);

    string forReturn = "";

    for (int i = 0; i < maxLen; i++)
    {
        foreach (string? set in selectedSets)
        {
            if (i < set.Length)
            {
                forReturn += set[i];
            }
        }
    }

    return forReturn;
}


List<string> UserChoiseSimvolse(in PasswordSettings settings)
{
    
    List<string> selectedSets = new List<string>();

    if (settings.useNums)    selectedSets.Add(Digits);      
    if (settings.UseLowerCase)   selectedSets.Add(LowerCase);   
    if (settings.useBigBuckvu)   selectedSets.Add(UpperCase);   
    if (settings.useSpecialChar) selectedSets.Add(SpecialChars);

    return selectedSets;
}

int MaxLenInListStrings(List<string> list)
{
    int max = 0;

    foreach (string s in list)
    {
        if (s.Length > max) max = s.Length;
    }

    return max;
}


string GeneratePassword(in short lens, in PasswordSettings settings)
{
    string sourceString = CreateSourceString(settings);
    
    string result = "";

    for(int i = 0; i  < lens; ++i)
    {
        int index = Random.Shared.Next(0, sourceString.Length);
        result += sourceString[index];
    }



    return result;
}



bool CheckUserNeedPassord(string password, in PasswordSettings settings)
{
    List<string> requiredSets = UserChoiseSimvolse(settings);

    foreach (string set in requiredSets)
    {
        bool isFound = false;

        foreach (char c in password)
        {
            if (set.Contains(c))
            {
                isFound = true;
                break; 
            }
        }

        if (isFound == false)
        {
            return false;
        }
    }

    return true;
}


struct PasswordSettings
{
    public bool useNums;
    public bool UseLowerCase;
    public bool useBigBuckvu;
    public bool useSpecialChar;
}