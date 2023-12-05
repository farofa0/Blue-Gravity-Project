using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
	public List<InventoryItem> Inventory { get; private set; } = new List<InventoryItem>();
	private Dictionary<Item, InventoryItem> itemDictionary = new Dictionary<Item, InventoryItem>();

    public delegate void OnGetItem();
    public static event OnGetItem onGetItem;

	public int Gold { get; private set; }

    public static InventorySystem Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public InventoryItem Get(Item item)
	{
        if (itemDictionary.TryGetValue(item, out InventoryItem value))
        {
            return value;
        }
		return null;
    }

	public void Add(Item item)
	{
		if (itemDictionary.TryGetValue(item, out InventoryItem value))
		{
			value.AddToStack();
		}
		else
		{
			InventoryItem newItem = new InventoryItem(item);
			Inventory.Add(newItem);
			itemDictionary.Add(item, newItem);
		}

        onGetItem?.Invoke();
    }

	public void Remove(Item item)
	{
		if (itemDictionary.TryGetValue(item, out InventoryItem value))
		{
			value.RemoveFromStack();

			if (value.stackSize == 0)
			{
				Inventory.Remove(value);
				itemDictionary.Remove(item);
			}
		}

        onGetItem?.Invoke();
    }

	public void BuyItem(Item item)
	{
        if (item.value <= Gold)
        {
            Gold -= item.value;
            Add(item);
        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }

	public void SellItem(Item item)
    {
        Gold += item.value / 2;
        Remove(item);
    }
}

