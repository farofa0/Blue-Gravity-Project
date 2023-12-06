using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class ShopFactory
{
    public static List<Shop> Shops
    {
        get
        {
            if (_shops == null)
            {
                _shops = LoadShopItems();
            }
            return _shops;
        }
    }

    private static List<Shop> _shops = null;
    private static List<Shop> LoadShopItems()
    {
        var itemList = new List<Shop>();

        List<Dictionary<string, object>> data = CSVReader.Read("ShopDatabase");
        for (int i = 0; i < data.Count; i++)
        {
            int shopId = int.Parse(data[i]["shopId"].ToString());

            List<int> itemsId = new List<int>();
            string[] numbers = data[i]["itemsId"].ToString().Replace("\"", "").Split(';');
            foreach (string number in numbers)
            {
                if (int.TryParse(number, out int intValue))
                {
                    itemsId.Add(intValue);
                }
            }

            itemList.Add(new Shop(shopId, itemsId));
        }

        return itemList;
    }

    public static Shop GetShop(int id)
    {
        return Shops.Find(shop => shop.shopId == id);
    }
}

