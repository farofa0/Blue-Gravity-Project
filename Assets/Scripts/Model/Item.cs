using System;

[Serializable]
public class Item
{
	public int id;
	public string name;
	public string description;
	public string itemType;
	public string sprite;
    public int value;

    public Item(int id, string name, string description, string itemType, string sprite, int value)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.itemType = itemType;
        this.sprite = sprite;
        this.value = value;
    }
}

