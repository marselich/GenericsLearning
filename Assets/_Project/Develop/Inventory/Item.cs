using System;

public class Item
{
    public Item(string name, int count)
    {
        if (count <= 0)
            throw new ArgumentOutOfRangeException(nameof(count), ExceptionMessages.ArgumentOutOfRangeExceptionMessage);

        Name = name;
        Count = count;
    }

    public string Name { get; private set; }
    public int Count { get; private set; }
}