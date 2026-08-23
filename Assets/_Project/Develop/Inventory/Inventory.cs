using System;
using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    private List<Item> _items;

    private int _currentSize;

    public Inventory(IReadOnlyList<Item> items, int maxSize)
    {
        if (maxSize <= 0)
            throw new ArgumentOutOfRangeException(nameof(maxSize), ExceptionMessages.ArgumentOutOfRangeExceptionMessage);

        _items = new List<Item>(items);
        MaxSize = maxSize;

        _currentSize = _items.Sum(item => item.Count);
    }

    public int CurrentSize => _currentSize;

    public int MaxSize { get; private set; }

    public IReadOnlyList<Item> Items => _items;

    public void Add(Item item)
    {
        if (_currentSize + item.Count > MaxSize)
            return;

        _currentSize += item.Count;

        _items.Add(item);
    }

    public List<Item> GetItemsBy(string name, int count)
    {
        if (count <= 0)
            throw new ArgumentOutOfRangeException(nameof(count), ExceptionMessages.ArgumentOutOfRangeExceptionMessage);

        List<Item> tempItems = new List<Item>();

        for (int i = 0; i < count; i++)
        {
            Item item = _items.First(item => item.Name == name);

            if (item == null)
                break;

            _items.Remove(item);
            tempItems.Add(item);

            _currentSize -= item.Count;
        }

        return tempItems;
    }
}