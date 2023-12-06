using UnityEngine;

public class ShopView : MonoBehaviour
{
    public GameObject shopItemPrefab;
    public int shopId = 1;

    private void OnEnable()
    {
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            Destroy(transform.GetChild(i).gameObject);
        }

        foreach (var itemId in ShopFactory.GetShop(shopId).itemsId)
        {
            var go = Instantiate(shopItemPrefab, transform);
            go.GetComponent<ShopItemView>().SetItem(ItemFactory.GetItem(itemId));
        }
    }
}