using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopView : MonoBehaviour
{
    public GameObject shopItemPrefab;

    private void OnEnable()
    {
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            Destroy(transform.GetChild(i).gameObject);
        }

        foreach (var itemId in ShopFactory.GetShop(1).itemsId)
        {
            var go = Instantiate(shopItemPrefab, transform);
            go.GetComponent<ShopItemView>().SetItem(ItemFactory.GetItem(itemId));
        }
    }
}