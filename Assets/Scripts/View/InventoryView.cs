using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryView : MonoBehaviour
{
    public GameObject inventoryItemPrefab;
    public TextMeshProUGUI txtGold;

    private void OnEnable()
    {
        InventorySystem.onGetItem += RefreshItems;
        RefreshItems();
    }

    private void OnDisable()
    {
        InventorySystem.onGetItem -= RefreshItems;
    }

    private void RefreshItems()
    {
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            Destroy(transform.GetChild(i).gameObject);
        }

        foreach (var item in InventorySystem.Instance.Inventory)
        {
            var go = Instantiate(inventoryItemPrefab, transform);
            go.GetComponent<InventoryItemView>().SetItem(item);
        }

        txtGold.text = InventorySystem.Instance.Gold + "$";
    }
}