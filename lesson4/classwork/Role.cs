namespace classwork;

internal class Role
{
    private int id;
    private string title;

    public Role(int id, string title)
    {
        this.id = id;
        this.title = title;
    }

    public void Render()
    {
        System.Console.WriteLine($"Role info: {id}, {title}");
    }


}
