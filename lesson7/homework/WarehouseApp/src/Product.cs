namespace WarehouseApp;


public class Product
{
    private string name;
    private double price;
    private int quantity;

    public Product(string name = "no_name", double price = -1, int quantity = -1)
    {
        if(name == "no_name")
        {
            this.name = RandomUtils.StringGenerator.GetRandomString(10);
        }else
        {
           this.name = name; 
        }

        if(price == -1)
        {
           this.price = RandomUtils.NumberGenerator.GetRandomNumber(0, 10000); 
        }
        else
        {
            this.price = price;
        }

        if(quantity == -1)
        {
            this.quantity = RandomUtils.NumberGenerator.GetRandomNumber(0, 100);
        }else
        {
            this.quantity = quantity;
        }
    }

    public string GetName()
    {
        return name;
    }

    public double GetPrice()
    {
        return price;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public override string ToString()
    {
        return $"Name: {name}, Price: {price}, Quantity: {quantity}";
    }

    public void Print()
    {
        System.Console.WriteLine(ToString());
    }

    public void PrintWithOutEnter()
    {
        System.Console.Write(ToString() + " | ");
    }

}