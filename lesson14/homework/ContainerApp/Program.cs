using ContainerApp.Container;

Container<int> intContainer = new Container<int>();
for(int i = 0; i < 30; ++i)
{
    intContainer.Add(i * 10);
}
intContainer.Render();

intContainer.Remove(7);
intContainer.Render();

System.Console.WriteLine();

System.Console.WriteLine(intContainer.Get(8));



Container<string> stringContainer = new Container<string>();
stringContainer.Add("Привет");
stringContainer.Add("Мир");
for(int i = 0; i < 30; ++i)
{
    stringContainer.Add((i*10).ToString());
}
stringContainer.Render();

stringContainer.Remove(4);
stringContainer.Render();

System.Console.WriteLine();

System.Console.WriteLine(stringContainer.Get(8));