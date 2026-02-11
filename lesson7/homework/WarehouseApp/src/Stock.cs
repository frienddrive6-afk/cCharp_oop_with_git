namespace WarehouseApp;

public class Stock
{
    private List<Product> products;

    public Stock()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product prod)
    {
        products.Add(prod);
    }

    public void AddProduct()
    {
        products.Add(new Product());
    }

    public void RemoveProduct(Product prod)
    {
        products.Remove(prod);
    }

    public void RemoveProduct(string name)
    {
        for (int i = products.Count - 1; i >= 0; i--)
        {
            if (products[i].GetName() == name)
            {
                products.RemoveAt(i);
                break;
            }
        }
    }

    public void PrintStrock()
    {
        foreach(Product prd in products)
        {
            prd.Print();
        }
    }

    public void PrintStrockWithOutEnter()
    {
        foreach(Product prd in products)
        {
            prd.PrintWithOutEnter();
        }
    }



}
