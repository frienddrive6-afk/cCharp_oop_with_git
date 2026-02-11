using RandomUtils;
using WarehouseApp; 


Stock stock = new Stock();

for(int i = 0; i < 15; ++i)
{
    stock.AddProduct(new Product());
}

stock.PrintStrock();
System.Console.WriteLine("-------------------------------------");
stock.PrintStrockWithOutEnter();