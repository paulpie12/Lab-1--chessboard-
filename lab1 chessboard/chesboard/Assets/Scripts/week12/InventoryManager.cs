using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<InventoryItem> InventoryItems = new List<InventoryItem>();

    private void Start()
    {
        // Populate the inventory with random items
        InitializeInventory();
    }

    private void InitializeInventory()
    {
        InventoryItems.Add(new InventoryItem(1, "Sword", Random.Range(10, 100)));
        InventoryItems.Add(new InventoryItem(2, "Shield", Random.Range(10, 100)));
        InventoryItems.Add(new InventoryItem(3, "Potion", Random.Range(10, 100)));
        InventoryItems.Add(new InventoryItem(4, "Bow", Random.Range(10, 100)));
        InventoryItems.Add(new InventoryItem(5, "Helmet", Random.Range(10, 100)));
        // Add more items as needed
    }

    // Task 1: Linear Search by Name
    public InventoryItem LinearSearchByName(string itemName)
    {
        foreach (var item in InventoryItems)
        {
            if (item.Name == itemName)
                return item;
        }
        return null;
    }

    // Task 2: Binary Search by ID
    public InventoryItem BinarySearchByID(int id)
    {
        InventoryItems.Sort((x, y) => x.ID.CompareTo(y.ID)); // Sort by ID
        int left = 0;
        int right = InventoryItems.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (InventoryItems[mid].ID == id)
                return InventoryItems[mid];
            if (InventoryItems[mid].ID < id)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    // Task 3: Quick Sort by Value
    public void QuickSortByValue()
    {
        QuickSort(0, InventoryItems.Count - 1);
    }

    private void QuickSort(int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(low, high);
            QuickSort(low, pivotIndex - 1);
            QuickSort(pivotIndex + 1, high);
        }
    }

    private int Partition(int low, int high)
    {
        int pivot = InventoryItems[high].Value;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (InventoryItems[j].Value <= pivot)
            {
                i++;
                Swap(i, j);
            }
        }

        Swap(i + 1, high);
        return i + 1;
    }

    private void Swap(int i, int j)
    {
        var temp = InventoryItems[i];
        InventoryItems[i] = InventoryItems[j];
        InventoryItems[j] = temp;
    }
}



public class InventoryItem
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Value { get; set; }

    public InventoryItem(int id, string name, int value)
    {
        ID = id;
        Name = name;
        Value = value;
    }
}

