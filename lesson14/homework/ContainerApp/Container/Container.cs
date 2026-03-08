namespace ContainerApp.Container;


public class Container<T>
{
    
    private T[] _items;
    private int _count;
    public int Count => _count;
    public int Capacity { get; private set; }

    public Container()
    {
        Capacity = 10;
        _items = new T[Capacity];
        _count = 0;
    }

    public void Add(T item)
    {
        if(_count == _items.Length)
        {
            Capacity += 10;
            T[] tempItems = new T[Capacity];
            for(int i = 0; i < _items.Length; ++i)
            {
                tempItems[i] = _items[i];
            }

            tempItems[_count] = item;
            _count++;
            _items = tempItems;
        }else
        {
            _items[_count] = item;
            _count++;
        }
    }

    public void Remove(int index)
    {
        if(index >= _count || index < 0 )
        {
            System.Console.WriteLine("Index out of range");
            return;
        }

        for(int i = index; i < _count - 1; ++i)
        {
            _items[i] = _items[i + 1];
        }
        _count--;


    }


    public T Get(int index)
    {
        return _items[index];
    }

    public void Render(int type = 0)
    {
        if(type == 0) 
        {       
            for(int i = 0; i < _count; ++i)
            {
                System.Console.Write(_items[i]?.ToString() + " ");
            }
            System.Console.WriteLine();
        }else
        {
            for(int i = _count - 1; i >= 0; --i)
            {
                System.Console.WriteLine(_items[i]?.ToString());
            }
        }
    }


}
