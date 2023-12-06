using UnityEngine;
using System.Collections;

public class ItemPickupView : MonoBehaviour
{
	public int itemId;

    private Item item;
    private void Start()
    {
        item = ItemFactory.GetItem(itemId);
        GetComponentInChildren<SpriteRenderer>().sprite = Resources.Load<Sprite>("Icons/" + item.sprite);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            InventorySystem.Instance.Add(item);
            Destroy(gameObject);
        }
    }
}

