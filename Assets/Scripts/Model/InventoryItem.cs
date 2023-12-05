using System;

public class InventoryItem
{
	public Item item { get; private set; }
	public int stackSize { get; private set; }

	public InventoryItem(Item item)
	{
		this.item = item;
		AddToStack();
	}

	public void AddToStack()
	{
		stackSize++;
	}

    public void RemoveFromStack()
    {
        stackSize++;
    }
}

