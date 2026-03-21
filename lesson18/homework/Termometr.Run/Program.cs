using Termometr.Core; 
using System.Diagnostics;
using System.Runtime.InteropServices;


Thermometer term = new Thermometer(20);

term.DelagetsList.Add(Logger);
term.DelagetsList.Add(Trevoga);
term.DelagetsList.Add(AudioLogger);


// term.SetTemperature(30);

while (true)
{
    System.Console.Write("Введите температуру(шасли хотите выйти введите 00): ");
    string? input = Console.ReadLine();
    if (input == "00") break;
    term.SetTemperature(Convert.ToInt32(input));
}



void Logger(int temp) => Console.WriteLine($"Лог: {temp}°C");

void Trevoga(int temp)
{
    if (temp >= 30) Console.WriteLine("ТРЕВОГА: Перегрев!");
}



void AudioLogger(int temp)
{
    int freq = 20 * temp;

    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    {
        //Нет поддержки на Linux :(  У меня нет звука
        Console.Beep(freq, 500);
    }
    else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
    {
        try 
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "speaker-test",
                Arguments = $"-t sine -f {freq} -l 1",
                CreateNoWindow = true,        // Не создавать окно
                UseShellExecute = false,      // перенаправления потоков
                RedirectStandardOutput = true, // вывод в пустоту
                RedirectStandardError = true   // ошибки в пустоту
            };

            Process proc = Process.Start(psi);

            Task.Delay(100).ContinueWith(_ => {
                try { proc?.Kill(); } catch { }
            });
        }
        catch { Console.WriteLine("Ошибка: speaker-test не найден."); }
    }
    else
    {
        Console.WriteLine($"Звук логика для вашей ОС отсутствует.");
    }
}