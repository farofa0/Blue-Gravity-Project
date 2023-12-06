using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class InventoryItemView : MonoBehaviour
{
    private Item item;

    public void SetItem(InventoryItem inventoryItem)
    {
        item = inventoryItem.item;
        GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Icons/" + inventoryItem.item.sprite);
        GetComponentInChildren<TextMeshProUGUI>().text = inventoryItem.stackSize.ToString();
    }

    public void SellItem()
    {
        if (UIController.Instance.shopPanel.activeInHierarchy)
        {
            InventorySystem.Instance.TrySellItem(item);
        }
        else
        {
            InventorySystem.Instance.TryEquipItem(item);
        }
    }
}