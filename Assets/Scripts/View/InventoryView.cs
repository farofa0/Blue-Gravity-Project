using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryView : MonoBehaviour
{
    public GameObject inventoryItemPrefab;

    private void OnEnable()
    {
        foreach (var item in InventorySystem.Instance.Inventory)
        {
            var go = Instantiate(inventoryItemPrefab, transform);
            go.GetComponent<InventoryItemView>().SetItem(item);
        }
    }

    private void OnDisable()
    {
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }
}