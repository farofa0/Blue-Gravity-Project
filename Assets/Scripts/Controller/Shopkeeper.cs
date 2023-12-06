using UnityEngine;
using System.Collections;

public class Shopkeeper : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        UIController.Instance.shopPanel.SetActive(true);
    }
}

