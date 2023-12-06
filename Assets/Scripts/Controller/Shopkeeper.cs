using UnityEngine;

public class Shopkeeper : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        UIController.Instance.shopPanel.SetActive(true);
    }
}

