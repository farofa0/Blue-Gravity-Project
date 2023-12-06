using UnityEngine;
using UnityEngine.UI;

public class ShopItemView : MonoBehaviour
{
    private Item item;

    public void SetItem(Item item)
    {
        this.item = item;
        GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Icons/" + item.sprite);
    }

    public void BuyItem()
    {
        InventorySystem.Instance.TryBuyItem(item);
    }
}