namespace Termometr.Core;




public class Thermometer
{
    public int Temperature { get; set; }

    public delegate void Delagets(int temperature);

    public List<Delagets> DelagetsList = new List<Delagets>();

    public Thermometer(int temperature)
    {
        Temperature = temperature;
    }

    public Thermometer()
    {
        Temperature = 0;
    }

    public void SetTemperature(int temperature)
    {
        Temperature = temperature;
        sendToObservers();
    }

    void sendToObservers()
    {
        try
        {
            foreach (Delagets delagets in DelagetsList)
            {
                delagets(Temperature);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}