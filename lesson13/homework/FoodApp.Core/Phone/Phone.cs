namespace FoodApp.Core.Phone;


public class Phone
{
    public string Number { get; private set; }

    private List<string> messeges = new List<string>();
    public Phone(string number)
    {
        Number = number;
    }

    public string GetSMS(string message)
    {
        messeges.Add(message);
        return $"Сообщение: {message}";
    }

    public void RenderMessages()
    {
        for(int i = 0; i < messeges.Count; ++i)
        {
            Console.WriteLine($"№{i+1}: {messeges[i]}");
        }
    }

    public void LastMessage()
    {
        if(messeges.Count > 0)
        {
            Console.WriteLine($"Последнее сообщение: {messeges[messeges.Count - 1]}");
        }else
        {
            Console.WriteLine("Нет сообщений");
        }
    
    }

    public string GetLastMessage()
    {
        return messeges[messeges.Count - 1];
    }
}