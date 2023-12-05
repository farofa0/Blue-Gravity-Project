using System;
using System.Collections.Generic;

public static class ItemFactory
{
    public static List<Item> Items
    {
        get
        {
            if (_items == null)
            {
                _items = LoadItems();
            }
            return _items;
        }
    }

    private static List<Item> _items = null;
    private static List<Item> LoadItems()
    {
        var itemList = new List<Item>();

        List<Dictionary<string, object>> data = CSVReader.Read("ItemDatabase");
        for (int i = 0; i < data.Count; i++)
        {
            int id = int.Parse(data[i]["id"].ToString());
            string name = data[i]["name"].ToString();
            string description = data[i]["description"].ToString();
            string itemType = data[i]["itemType"].ToString();
            string sprite = data[i]["sprite"].ToString();
            int value = int.Parse(data[i]["value"].ToString());

            itemList.Add(new Item(id, name, description, itemType, sprite, value));
        }

        return itemList;
    }

    public static Item GetItem(int id)
    {
        return Items.Find(item => item.id == id);
    }
}

