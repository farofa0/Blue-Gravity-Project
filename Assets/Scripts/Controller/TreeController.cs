using UnityEngine;

public class TreeController : MonoBehaviour, IInteractable
{
    public GameObject itemPrefab;
    public int hp = 5;
    public int lootID = 1;

    private HitPoints hitPoints;

    void Start()
    {
        hitPoints = new HitPoints(hp);
    }

    public void Interact()
    {
        Debug.Log("Chop");
        hitPoints.ApplyDamage(1);
        GetComponent<Animator>().SetTrigger("Chop");
        
        if (hitPoints.IsDead)
        {
            GetComponent<TreeView>().ChopTree();
            itemPrefab.GetComponent<ItemPickupView>().itemId = lootID;
            Instantiate(itemPrefab, transform);
        }
    }
}

