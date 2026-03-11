using UnityEngine;

public class InventoryItem
{
    public string Name { get; private set; }
    public int Quantity { get; private set; }
    public ItemData Data { get; private set; }
    public InventoryItem(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public void AddQuantity(int amount)
    {
        Quantity += amount;
    }

    public void RemoveQuantity(int amount)
    {
        Quantity = Mathf.Max(0, Quantity - amount);
    }
}