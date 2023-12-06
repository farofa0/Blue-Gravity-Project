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
    public string animation;

    public Item(int id, string name, string description, string itemType, string sprite, int value, string animation)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.itemType = itemType;
        this.sprite = sprite;
        this.value = value;
        this.animation = animation;
    }
}

