using System;
using System.Collections.Generic;

public class Shop
{
    public int shopId;
    public List<int> itemsId;

    public Shop(int shopId, List<int> itemsId)
    {
        this.shopId = shopId;
        this.itemsId = itemsId;
    }
}

