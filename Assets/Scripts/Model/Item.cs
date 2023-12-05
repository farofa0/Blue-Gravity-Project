using System;

[Serializable]
public class Item
{
	public int id;
	public string name;
	public string description;
	public string itemType;
	public string sprite;

    public Item(int id, string name, string description, string itemType, string sprite)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.itemType = itemType;
        this.sprite = sprite;
    }
}

