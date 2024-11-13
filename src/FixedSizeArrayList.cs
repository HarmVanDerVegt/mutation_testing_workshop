namespace mutation_testing;


public class FixedSizeArrayList<T>
{
    private T[] items;
    private int count;

    public FixedSizeArrayList(int capacity)
    {
        items = new T[capacity];
        count = 0;
    }

    public int Count => count;
    public int Capacity => items.Length;

    public void Add(T item)
    {
        if (count < Capacity) 
        {
            items[count] = item;
            count++;
        }
        else
        {
            throw new InvalidOperationException("List is at full capacity.");
        }
    }

    public T Get(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
        return items[index];
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }

        items[count - 1] = default;
        count--;
    }
}
