using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemView : MonoBehaviour
{
    public void SetItem(InventoryItem inventoryItem)
    {
        GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Icons/" + inventoryItem.item.sprite);
        GetComponentInChildren<TextMeshProUGUI>().text = inventoryItem.stackSize.ToString();
    }
}